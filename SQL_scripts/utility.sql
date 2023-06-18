SET WRAP ON;
--CONNECT ATBM_QLNV/team18@//localhost:1521/ATBM_QLNV_OLS;

SELECT *
FROM DBA_OBJECTS
WHERE OBJECT_NAME IN ('THONGBAO', 'NHANVIEN', 'DEAN', 'PHONGBAN', 'PHANCONG');

SELECT *
FROM ALL_OBJECTS
WHERE OBJECT_NAME IN ('THONGBAO', 'NHANVIEN', 'DEAN', 'PHONGBAN', 'PHANCONG');

SELECT *
FROM USER_OBJECTS
WHERE OBJECT_NAME IN ('THONGBAO', 'NHANVIEN', 'DEAN', 'PHONGBAN', 'PHANCONG');

SET WRAP OFF;
SELECT USERNAME, COMMON, ORACLE_MAINTAINED
FROM DBA_USERS
WHERE USERNAME IN ('NV001', 'TGD', 'ATBM_QLNV');

--DROP TABLE ATBM_QLNV.NHANVIEN CASCADE CONSTRAINTS;
--DROP TABLE ATBM_QLNV.PHONGBAN CASCADE CONSTRAINTS;
--DROP TABLE ATBM_QLNV.DEAN CASCADE CONSTRAINTS;
--DROP TABLE ATBM_QLNV.PHANCONG CASCADE CONSTRAINTS;
--DROP TABLE ATBM_QLNV.THONGBAO CASCADE CONSTRAINTS;