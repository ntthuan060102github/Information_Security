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
--VPD de ap cac chinh sach lien quan den viec xem tren quan he NHANVIEN
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
    --CS#2: QL truc tiep duoc xem cac dong du lieu NHANVIEN lien quan den minh hoac nhan vien ma minh quan ly
    IF EMP_ROLE = 'QLTRUCTIEP' THEN
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || ' OR MANQL = ' || '''' || EMP_ID || '''';
    --CS#3: Truong phong duoc xem cac dong du lieu NHANVIEN cua den minh hoac nhan vien thuoc phong ban cua minh
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
    --CS#4: Tai chinh duoc xem tren toan bo quan he NHANVIEN
    ELSIF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := '1 = 1';
    --CS#1: Nhan vien duoc xem cac dong du lieu NHANVIEN cua chinh minh
    ELSE
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''';
    END IF;    

    RETURN PREDICATE;
END VPD_RETRIEVE_NHANVIEN;
/
--VPD de ap them cac chinh sach lien quan den viec xem truong LUONG, PHUCAP trong NHANVIEN
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
    --CS#4: Tai chinh duoc xem LUONG, PHUCAP cua toan bo quan he NHANVIEN
    IF EMP_ROLE = 'TAICHINH' THEN
        RETURN '1 = 1';
    --CS#1: Nhan vien duoc xem LUONG, PHUCAP cua chinh minh
    --CS#2: QL truc tiep chi duoc xem LUONG, PHUCAP cua chinh minh (khong duoc xem cua nhan vien minh quan ly)
    ELSE
        RETURN 'MANV = ' || '''' || EMP_ID || ''''; 
    END IF;
END VPD_SEC_RETRIEVE_NHANVIEN;
/
--VPD de ap cac chinh sach lien quan den viec sua tren quan he NHANVIEN
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
    --CS#1: Nhan vien chi duoc sua tren du lieu cua chinh minh
    IF EMP_ROLE IN ('NHANVIEN', 'QLTRUCTIEP', 'TRUONGPHONG') THEN
        PREDICATE := 'MANV = ' || EMP_ID;
    --CS#4: Tai chinh duoc cap nhat LUONG, PHUCAP cua toan bo NHANVIEN nhung chi duoc cap nhat NGAYSINH, DIACHI, SODT cua chinh minh (trong VPD_SEC_UPDATE_NHANVIEN)
    ELSIF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := '1 = 1';
    --CS#5: Nhan su duoc cap nhat du lieu tren toan quan he NHANVIEN nhung khong duoc cap nhat LUONG, PHUCAP (trong VPD_THIRD_UPDATE_NHANVIEN)
    ELSIF EMP_ROLE = 'NHANSU' THEN    
        PREDICATE := '1 = 1';
    END IF;
    
    RETURN PREDICATE;
END;
/

--VPD de ap cac chinh sach lien quan den viec sua NGAYSINH,DIACHI,SODT tren quan he NHANVIEN
CREATE OR REPLACE FUNCTION VPD_SEC_UPDATE_NHANVIEN(
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
    --CS#4: Tai chinh chi duoc cap nhat NGAYSINH, DIACHI, SODT cua minh
    IF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := 'MANV = ' || EMP_ID;
    --CS#5: Nhan su duoc cap nhat toan bo NGAYSINH, DIACHI, SODT
    ELSIF EMP_ROLE = 'NHANSU' THEN
        PREDICATE := '1 = 1';
    END IF;
    
    RETURN PREDICATE;
END;
/

--VPD de ap cac chinh sach lien quan den viec sua LUONG, PHUCAP tren quan he NHANVIEN
CREATE OR REPLACE FUNCTION VPD_THIRD_UPDATE_NHANVIEN(
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
    --CS#4: Tai chinh chi duoc cap nhat LUONG, PHUCAP
    IF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := '1 = 1';
    --CS#5: Nhan su khong duoc cap nhat LUONG, PHUCAP
    ELSIF EMP_ROLE = 'NHANSU' THEN
        PREDICATE := '1 = 0';
    END IF;
    
    RETURN PREDICATE;
END;
/

--VPD de ap cac chinh sach lien quan den viec xem tren quan he PHANCONG
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
    --CS#2: QLTRUCTIEP co the xem du lieu PHANCONG cua minh va cac nhan vien ma minh quan ly
    IF EMP_ROLE = 'QLTRUCTIEP' THEN
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || ' OR MANV IN (SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE MANQL = ' || '''' || EMP_ID || ''')';
    --CS#3: Truong phong duoc xem tren PHANCONG cua nhan vien thuoc phong ban
    ELSIF EMP_ROLE = 'TRUONGPHONG' THEN
        PREDICATE := 'MANV = ' || '''' || EMP_ID || '''' || ' OR MANV IN (SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE MANV != ' || '''' || EMP_ID || ''')';
    --CS#4: Tai chinh duoc xem tren toan bo quan he PHANCONG
    ELSIF EMP_ROLE = 'TAICHINH' THEN
        PREDICATE := '1 = 1';
    --CS#1: Nhan vien duoc xem du lieu PHANCONG cua chinh minh
    ELSE
        RETURN 'MANV = ' || '''' || EMP_ID || '''';    
    END IF;

    RETURN PREDICATE;
END VPD_RETRIEVE_PHANCONG;
/
--VPD de ap cac chinh sach lien quan den viec them tren quan he PHANCONG
CREATE OR REPLACE FUNCTION VPD_INSERT_PHANCONG(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
    MANAGE_DEPARTMENT VARCHAR2(5);
BEGIN
    --CS#3: Truong phong co the them tren quan he PHANCONG lien quan den nhan vien thuoc phong ban cua minh
    IF EMP_ROLE = 'TRUONGPHONG' THEN
        BEGIN
            SELECT MAPB INTO MANAGE_DEPARTMENT
            FROM PHONGBAN
            WHERE TRPHG = EMP_ID
            FETCH FIRST 1 ROWS ONLY;
        EXCEPTION
            WHEN OTHERS THEN MANAGE_DEPARTMENT := 'XXX';
        END;
        PREDICATE := 'MANV IN (SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE PHG = ' || '''' || MANAGE_DEPARTMENT || ''')';
    END IF;
    
    RETURN PREDICATE;
END;
/
--VPD de ap cac chinh sach lien quan den viec sua tren quan he PHANCONG
CREATE OR REPLACE FUNCTION VPD_UPDATE_PHANCONG(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
    MANAGE_DEPARTMENT VARCHAR2(5);
BEGIN
    --CS#3: Truong phong co the sua tren quan he PHANCONG lien quan den nhan vien thuoc phong ban cua minh
    IF EMP_ROLE = 'TRUONGPHONG' THEN
        BEGIN
            SELECT MAPB INTO MANAGE_DEPARTMENT
            FROM PHONGBAN
            WHERE TRPHG = EMP_ID
            FETCH FIRST 1 ROWS ONLY;
        EXCEPTION
            WHEN OTHERS THEN MANAGE_DEPARTMENT := 'XXX';
        END;
        PREDICATE := 'MANV IN (SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE PHG = ' || '''' || MANAGE_DEPARTMENT || ''')';
    END IF;
    
    RETURN PREDICATE;
END;
/
--VPD de ap cac chinh sach lien quan den viec xoa tren quan he PHANCONG
CREATE OR REPLACE FUNCTION VPD_DELETE_PHANCONG(
    P_SCHEMA IN VARCHAR2,
    P_OBJECT IN VARCHAR2
)
RETURN VARCHAR2
AS
    CURR_USER VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    EMP_ID VARCHAR2(7) := SUBSTR(CURR_USER, 3);
    EMP_ROLE VARCHAR2(50) := UPPER(REPLACE(SYS_CONTEXT('VPD_CTX', 'USER_ROLE'), ' ', ''));
    PREDICATE VARCHAR2(1000) DEFAULT '1 = 0';
    MANAGE_DEPARTMENT VARCHAR2(5);
BEGIN
    --CS#3: Truong phong co the xoa tren quan he PHANCONG lien quan den nhan vien thuoc phong ban cua minh
    IF EMP_ROLE = 'TRUONGPHONG' THEN
        BEGIN
            SELECT MAPB INTO MANAGE_DEPARTMENT
            FROM PHONGBAN
            WHERE TRPHG = EMP_ID
            FETCH FIRST 1 ROWS ONLY;
        EXCEPTION
            WHEN OTHERS THEN MANAGE_DEPARTMENT := 'XXX';
        END;
        PREDICATE := 'MANV IN (SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE PHG = ' || '''' || MANAGE_DEPARTMENT || ''')';
    END IF;
    
    RETURN PREDICATE;
END;
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
      object_name     => 'NHANVIEN',
      policy_name     => 'VPD_SEC_UPDATE_NHANVIEN'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'NHANVIEN',
      policy_name     => 'VPD_THIRD_UPDATE_NHANVIEN'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'PHANCONG',
      policy_name     => 'VPD_RETRIEVE_PHANCONG'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'PHANCONG',
      policy_name     => 'VPD_INSERT_PHANCONG'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'PHANCONG',
      policy_name     => 'VPD_UPDATE_PHANCONG'
    );
    DBMS_RLS.DROP_POLICY(
      object_schema   => 'ATBM_QLNV',
      object_name     => 'PHANCONG',
      policy_name     => 'VPD_DELETE_PHANCONG'
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
        object_name      => 'NHANVIEN',
        policy_name      => 'VPD_SEC_UPDATE_NHANVIEN',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_SEC_UPDATE_NHANVIEN',
        statement_types  => 'UPDATE',
        sec_relevant_cols => 'NGAYSINH,DIACHI,SODT',
        update_check     => TRUE
    );
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'NHANVIEN',
        policy_name      => 'VPD_THIRD_UPDATE_NHANVIEN',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_THIRD_UPDATE_NHANVIEN',
        statement_types  => 'UPDATE',
        sec_relevant_cols => 'LUONG,PHUCAP',
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
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'PHANCONG',
        policy_name      => 'VPD_INSERT_PHANCONG',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_INSERT_PHANCONG',
        statement_types  => 'INSERT',
        update_check     => TRUE
    );
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'PHANCONG',
        policy_name      => 'VPD_UPDATE_PHANCONG',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_UPDATE_PHANCONG',
        statement_types  => 'UPDATE',
        update_check     => TRUE
    );
    DBMS_RLS.ADD_POLICY (
        object_schema    => 'ATBM_QLNV',
        object_name      => 'PHANCONG',
        policy_name      => 'VPD_DELETE_PHANCONG',
        function_schema  => 'ATBM_QLNV',
        policy_function  => 'VPD_DELETE_PHANCONG',
        statement_types  => 'DELETE',
        update_check     => TRUE
    );
END;
/

