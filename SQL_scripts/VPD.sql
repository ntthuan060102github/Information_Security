CONNECT ATBM_QLNV/team18@//localhost:1521/ATBM_QLNV_PDB;
--ALTER SESSION SET CURRENT_SCHEMA=ATBM_QLNV;
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;

CREATE OR REPLACE PACKAGE VPD_PKG AS
    PROCEDURE SET_VAITRO(VAITRO IN NVARCHAR2);
END VPD_PKG;
/
CREATE OR REPLACE CONTEXT VPD_CTX USING VPD_PKG;
/
CREATE OR REPLACE TRIGGER SET_VAITRO_TRIGGER
AFTER LOGON ON DATABASE
BEGIN
    DECLARE
        VAITRO NHANVIEN.VAITRO%TYPE;
        MANV NHANVIEN.MANV%TYPE;
    BEGIN
        SELECT VAITRO, MANV INTO VAITRO, MANV
        FROM NHANVIEN
        WHERE 'NV'||MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
        
        VPD_PKG.SET_VAITRO(VAITRO);
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            VPD_PKG.SET_VAITRO(NULL);
    END;
END;
/
CREATE OR REPLACE PACKAGE BODY VPD_PKG AS
    PROCEDURE SET_VAITRO(
        VAITRO IN NVARCHAR2
    ) 
    IS
    BEGIN
        DBMS_SESSION.SET_CONTEXT('VPD_CTX', 'USER_ROLE', VAITRO);
    END SET_VAITRO;
END VPD_PKG;
/
CREATE OR REPLACE FUNCTION VPD_RETRIEVE_NHANVIEN(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
    MANAGE_DEPARTMENT VARCHAR2(5);
BEGIN
    IF EMP_ROLE = 'QLTRUCTIEP' THEN
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || ' OR MANQL = ' || '''' || EMP_ID || '''';
    ELSIF EMP_ROLE = 'TRUONGPHONG' THEN
        BEGIN
            SELECT MAPB INTO MANAGE_DEPARTMENT
            FROM PHONGBAN
            WHERE TRPHG = EMP_ID
            FETCH FIRST 1 ROWS ONLY;
        EXCEPTION
            WHEN OTHERS THEN MANAGE_DEPARTMENT := 'XXX';
        END;
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || ' OR PHG = ' || '''' || MANAGE_DEPARTMENT || '''';
    ELSIF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := '1 = 1';
    ELSE
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''';
    END IF;    

    RETURN PREDICATE;
END VPD_RETRIEVE_NHANVIEN;
/
CREATE OR REPLACE FUNCTION VPD_SEC_RETRIEVE_NHANVIEN(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
BEGIN
    IF EMP_ROLE = 'TAICHINH' THEN
        RETURN '1 = 1';
    ELSE
        RETURN 'MANV = ' || '''' || EMP_ID || ''''; 
    END IF;
END VPD_SEC_RETRIEVE_NHANVIEN;
/

CREATE OR REPLACE FUNCTION VPD_UPDATE_NHANVIEN(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
BEGIN
--    DBMS_OUTPUT.PUT_LINE(DBMS_SQL.DESCRIBE_COLUMNS);
    IF EMP_ROLE IN ('NHANVIEN', 'QLTRUCTIEP', 'TRUONGPHONG') THEN
        PREDICATE := 'MANV = ' || EMP_ID;
    ELSIF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := 'NOT(NOT(EMP_ID = ' || EMP_ID || ') AND (COLUMN_NAME = ''LUONG '' OR COLUMN_NAME = ''PHUCAP '''  ;
        
    ELSIF EMP_ROLE = 'NHANSU' THEN    
        PREDICATE := 'LUONG IS NULL AND PHU CAP IS NULL';
    END IF;
    
    RETURN PREDICATE;
END;
/

CREATE OR REPLACE FUNCTION VPD_RETRIEVE_PHANCONG(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
BEGIN
    -- CS#2: QLTRUCTIEP co the xem cac dong trong PHANCONG lien quan den chinh Q
    --va cac nhan vien duoc quan ly truc tiep boi Q
    IF EMP_ROLE = 'QLTRUCTIEP' THEN
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || 
        ' OR MANV IN (SELECT MANV FROM NHANVIEN WHERE MANQL = ' || 
        '''' || EMP_ID || '''' || ')';
        
    END IF;

    RETURN PREDICATE;
END VPD_RETRIEVE_PHANCONG;
/

BEGIN
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'NHANVIEN',
      policy_name     => 'VPD_RETRIEVE_NHANVIEN'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'NHANVIEN',
      policy_name     => 'VPD_SEC_RETRIEVE_NHANVIEN'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'NHANVIEN',
      policy_name     => 'VPD_UPDATE_NHANVIEN'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'PHANCONG',
      policy_name     => 'VPD_RETRIEVE_PHANCONG'
    );
EXCEPTION
    WHEN OTHERS THEN RETURN;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'NHANVIEN',
        policy_name      => 'VPD_RETRIEVE_NHANVIEN',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_RETRIEVE_NHANVIEN',
        statement_types  => 'SELECT'
    );
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'NHANVIEN',
        policy_name      => 'VPD_SEC_RETRIEVE_NHANVIEN',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_SEC_RETRIEVE_NHANVIEN',
        statement_types  => 'SELECT',
        sec_relevant_cols => 'LUONG,PHUCAP',
        sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS
    );
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'NHANVIEN',
        policy_name      => 'VPD_UPDATE_NHANVIEN',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_UPDATE_NHANVIEN',
        statement_types  => 'UPDATE',
        update_check     => TRUE
    );
     DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'PHANCONG',
        policy_name      => 'VPD_RETRIEVE_PHANCONG',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_RETRIEVE_PHANCONG',
        statement_types  => 'SELECT'
    );
END;
/

