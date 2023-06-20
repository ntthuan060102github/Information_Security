CONNECT ATBM_QLNV/team18@//localhost:1521/ATBM_QLNV_PDB;
--ALTER SESSION SET CURRENT_SCHEMA=ATBM_QLNV;
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;

BEGIN
    FOR usr IN
    (
        SELECT USERNAME
        FROM dba_users
        WHERE USERNAME IN (
            SELECT 'NV' || MANV 
            FROM NHANVIEN
        )
    )
    LOOP
        --Xoa user
        EXECUTE IMMEDIATE 'DROP USER  '||usr.USERNAME||' CASCADE';
    END LOOP;
END;
/

-- Procedure tao user
CREATE OR REPLACE PROCEDURE CREATE_USER
AS
    CURSOR Cur IS (
        SELECT MANV, SODT 
        FROM NHANVIEN 
        WHERE 'NV' || MANV NOT IN (
            SELECT USERNAME 
            FROM ALL_USERS
        )
    );
    usr Cur%rowtype;
    pass VARCHAR2(40);
BEGIN
    OPEN Cur;
    LOOP
        FETCH Cur INTO usr;
        EXIT WHEN Cur%NOTFOUND;
        pass:= CONCAT('NV',usr.MANV);
        EXECUTE IMMEDIATE 'CREATE USER '||CONCAT('NV',usr.MANV)||' IDENTIFIED BY '||pass;
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION, CONNECT TO '||CONCAT('NV',usr.MANV);
    END LOOP;
    CLOSE Cur;
    
END;
/
EXEC CREATE_USER;
/

-- Drop cac role neu ton tai
BEGIN
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_NHANVIEN_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_QLTRUCTIEP_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_TRUONGPHONG_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_TAICHINH_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_NHANSU_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_TRUONGDEAN_ATBM';
    EXECUTE IMMEDIATE 'DROP ROLE ROLE_BANGIAMDOC_ATBM';
EXCEPTION
   WHEN OTHERS THEN RETURN;
END;
/

-- Tao cac role
CREATE ROLE ROLE_NHANVIEN_ATBM;
GRANT CREATE SESSION TO ROLE_NHANVIEN_ATBM;
--CS#1: Nhan vien co the sua tren cac thuoc tinh NGAYSINH, DIACHI, SODT cua chinh minh
GRANT SELECT, UPDATE (NGAYSINH, DIACHI, SODT) ON NHANVIEN TO ROLE_NHANVIEN_ATBM;
--CS#1: Nhan vien co the xem tren toan bo quan he PHONGBAN
GRANT SELECT ON PHONGBAN TO ROLE_NHANVIEN_ATBM;
--CS#1: Nhan vien co the xem tren toan bo quan he DEAN
GRANT SELECT ON DEAN TO ROLE_NHANVIEN_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_NHANVIEN_ATBM;

CREATE ROLE ROLE_QLTRUCTIEP_ATBM;
GRANT CREATE SESSION TO ROLE_QLTRUCTIEP_ATBM;
GRANT SELECT, UPDATE (NGAYSINH, DIACHI, SODT) ON NHANVIEN TO ROLE_QLTRUCTIEP_ATBM;
GRANT SELECT ON PHONGBAN TO ROLE_QLTRUCTIEP_ATBM;
GRANT SELECT ON DEAN TO ROLE_QLTRUCTIEP_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_QLTRUCTIEP_ATBM;

CREATE ROLE ROLE_TRUONGPHONG_ATBM;
GRANT CREATE SESSION TO ROLE_TRUONGPHONG_ATBM;
GRANT SELECT, UPDATE (NGAYSINH, DIACHI, SODT) ON NHANVIEN TO ROLE_TRUONGPHONG_ATBM;
GRANT SELECT ON PHONGBAN TO ROLE_TRUONGPHONG_ATBM;
GRANT SELECT ON DEAN TO ROLE_TRUONGPHONG_ATBM;
GRANT SELECT, INSERT, UPDATE, DELETE ON PHANCONG TO ROLE_TRUONGPHONG_ATBM;

CREATE ROLE ROLE_TAICHINH_ATBM;
GRANT CREATE SESSION TO ROLE_TAICHINH_ATBM;
GRANT SELECT, UPDATE (NGAYSINH, DIACHI, SODT, LUONG, PHUCAP) ON NHANVIEN TO ROLE_TAICHINH_ATBM;
GRANT SELECT ON PHONGBAN TO ROLE_TAICHINH_ATBM;
GRANT SELECT ON DEAN TO ROLE_TAICHINH_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_TAICHINH_ATBM;

CREATE ROLE ROLE_NHANSU_ATBM;
GRANT CREATE SESSION TO ROLE_NHANSU_ATBM;
CONNECT ATBM_QLNV/team18@//localhost:1521/ATBM_QLNV_PDB;
GRANT SELECT, UPDATE, INSERT(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) ON NHANVIEN TO ROLE_NHANSU_ATBM;
--CS#5: Nhan su duoc quyen them, cap nhat PHONGBAN
GRANT SELECT, INSERT, UPDATE ON PHONGBAN TO ROLE_NHANSU_ATBM;
GRANT SELECT ON DEAN TO ROLE_NHANSU_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_NHANSU_ATBM;

CREATE ROLE ROLE_TRUONGDEAN_ATBM;
GRANT CREATE SESSION TO ROLE_TRUONGDEAN_ATBM;
GRANT SELECT, UPDATE (NGAYSINH, DIACHI, SODT) ON NHANVIEN TO ROLE_TRUONGDEAN_ATBM;
GRANT SELECT ON PHONGBAN TO ROLE_TRUONGDEAN_ATBM;
--CS#6: Truong de an duoc quyen them, xoa, cap nhat tren DEAN
GRANT SELECT, INSERT, UPDATE, DELETE ON DEAN TO ROLE_TRUONGDEAN_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_TRUONGDEAN_ATBM;

CREATE ROLE ROLE_BANGIAMDOC_ATBM;
--Ban giam doc duoc quyen xem tat ca cac bang
GRANT SELECT ON NHANVIEN TO ROLE_BANGIAMDOC_ATBM;
GRANT SELECT ON PHONGBAN TO ROLE_BANGIAMDOC_ATBM;
GRANT SELECT ON DEAN TO ROLE_BANGIAMDOC_ATBM;
GRANT SELECT ON PHANCONG TO ROLE_BANGIAMDOC_ATBM;

-- Procedure cap role cho user theo VAITRO
CREATE OR REPLACE PROCEDURE GRANT_ROLE_TO_USER
AS
BEGIN
    FOR usr IN
    (
        SELECT MANV, VAITRO
        FROM NHANVIEN 
        WHERE 'NV'||MaNV IN (
            SELECT USERNAME 
            FROM ALL_USERS
        )
    )
    LOOP
        EXECUTE IMMEDIATE 'GRANT ROLE_' || UPPER(REPLACE(usr.VAITRO, ' ', '')) || '_ATBM TO '|| CONCAT('NV',usr.MANV);
    END LOOP;
END;
/
EXEC GRANT_ROLE_TO_USER;

BEGIN
    EXECUTE IMMEDIATE 'DROP USER TGD CASCADE';
    EXECUTE IMMEDIATE 'DROP USER TP_SX_MN CASCADE';
    EXECUTE IMMEDIATE 'DROP USER TP_SX_MB CASCADE';
    EXECUTE IMMEDIATE 'DROP USER TP_GC_MN CASCADE';
    EXECUTE IMMEDIATE 'DROP USER GB_MB CASCADE';
EXCEPTION 
    WHEN OTHERS THEN RETURN;
END;
/

CREATE USER TGD IDENTIFIED BY TGD;
CREATE USER TP_SX_MN IDENTIFIED BY TP_SX_MN;
CREATE USER TP_SX_MB IDENTIFIED BY TP_SX_MB;
CREATE USER TP_GC_MN IDENTIFIED BY TP_GC_MN;
CREATE USER GB_MB IDENTIFIED BY GB_MB;

GRANT CONNECT, CREATE SESSION TO TGD, TP_SX_MN, TP_SX_MB, TP_GC_MN, GB_MB;
GRANT SELECT ON ATBM_QLNV.THONGBAO TO TGD, TP_SX_MN, TP_SX_MB, TP_GC_MN, GB_MB;
GRANT DELETE ON ATBM_QLNV.THONGBAO TO TGD;