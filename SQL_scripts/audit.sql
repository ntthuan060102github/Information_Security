SET WRAP ON;
CONN SYS/Thuan123@//localhost:1521/ATBM_QLNV_PDB AS SYSDBA;

--------------------------------------------------------------------------------
-- CS: Nhung nguoi da cap nhat truong THOIGIAN trong quan he phan cong
AUDIT UPDATE ON ATBM_QLNV.PHANCONG BY ACCESS;
NOAUDIT UPDATE ON ATBM_QLNV.PHANCONG;

-- FGA
BEGIN
    DBMS_FGA.DROP_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'AUDIT_UPDATE_PHANCONG_THOIGIAN'
    );
EXCEPTION 
    WHEN OTHERS THEN RETURN;
END;
/

BEGIN
    DBMS_FGA.ADD_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'PHANCONG',
        POLICY_NAME => 'AUDIT_UPDATE_PHANCONG_THOIGIAN',
        AUDIT_CONDITION => NULL,
        AUDIT_COLUMN => 'THOIGIAN',
        ENABLE => TRUE,
        STATEMENT_TYPES => 'UPDATE'
    );
END;
/
--------------------------------------------------------------------------------
--CS: Nhung nguoi da doc tren truong LUONG va PHUCAP cua nguoi khac
--Standard audit
AUDIT SELECT ON ATBM_QLNV.NHANVIEN BY ACCESS;
NOAUDIT SELECT ON ATBM_QLNV.NHANVIEN;

-- FGA
BEGIN
    DBMS_FGA.DROP_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'AUDIT_SELECT_NHANVIEN_LUONG_PHUCAP'
    );
EXCEPTION 
    WHEN OTHERS THEN RETURN;
END;
/

BEGIN
    DBMS_FGA.ADD_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'AUDIT_SELECT_NHANVIEN_LUONG_PHUCAP',
        AUDIT_CONDITION => 'MANV <> SUBSTR(SYS_CONTEXT(''USERENV'', ''SESSION_USER''), 2)',
        AUDIT_COLUMN => 'LUONG,PHUCAP',
        ENABLE => TRUE,
        STATEMENT_TYPES => 'SELECT'
    );
END;
/
--------------------------------------------------------------------------------------------
--CS: Mot nguoi khong thuoc vai tro 'Tai chinh' nhung da cap nhat thanh cong tren LUONG va PHUCAP
--Standard Audit
AUDIT UPDATE ON ATBM_QLNV.NHANVIEN BY ACCESS WHENEVER SUCCESSFUL;
NOAUDIT UPDATE ON ATBM_QLNV.NHANVIEN;

--FGA
BEGIN
    DBMS_FGA.DROP_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'AUDIT_UPDATE_NHANVIEN_LUONG_PHUCAP'
    );
EXCEPTION 
    WHEN OTHERS THEN RETURN;
END;
/

BEGIN
    DBMS_FGA.ADD_POLICY(
        OBJECT_SCHEMA => 'ATBM_QLNV',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'AUDIT_UPDATE_NHANVIEN_LUONG_PHUCAP',
        AUDIT_CONDITION => 'UPPER(REPLACE(SYS_CONTEXT(''VPD_CTX'', ''USER_ROLE''), '' '', '''')) <> ''TAICHINH''',
        AUDIT_COLUMN => 'LUONG, PHUCAP',
        ENABLE => TRUE,
        STATEMENT_TYPES => 'UPDATE'
    );
END;