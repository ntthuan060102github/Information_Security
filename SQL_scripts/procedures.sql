clear scr;
CONN SYS/admin@//localhost:1521/ATBM_QLNV_PDB AS SYSDBA;
SET SERVEROUTPUT ON;

-- Schema dùng cho DATH
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE; 

GRANT ALL PRIVILEGES TO ATBM_QLNV WITH ADMIN OPTION;
ALTER USER ATBM_QLNV QUOTA UNLIMITED ON USERS;
GRANT EXECUTE ON DBMS_CRYPTO TO ATBM_QLNV;
ALTER SESSION SET CURRENT_SCHEMA = ATBM_QLNV;
GRANT CREATE SESSION TO ATBM_QLNV;	
GRANT EXECUTE ON DBMS_SESSION TO ATBM_QLNV;

GRANT SELECT ON ALL_USERS TO ATBM_QLNV;
GRANT SELECT ON DBA_ROLES TO ATBM_QLNV;
GRANT SELECT ON USER_OBJECTS TO ATBM_QLNV;
GRANT SELECT ON ALL_TAB_COLUMNS TO ATBM_QLNV;
GRANT SELECT ON DBA_TAB_PRIVS TO ATBM_QLNV;
GRANT SELECT ON DBA_COL_PRIVS TO ATBM_QLNV;
GRANT SELECT ON DBA_ROLE_PRIVS TO ATBM_QLNV;
GRANT SELECT ON USER_OBJECTS TO ATBM_QLNV;
GRANT SELECT ON DBA_OBJECTS TO ATBM_QLNV;
GRANT SELECT ON DBA_SYS_PRIVS TO ATBM_QLNV;

CREATE OR REPLACE PROCEDURE SP_GET_DB_ROLE (
    role_R OUT VARCHAR2
)
IS
    flag NUMBER(1);
BEGIN
    --DBA?
    IF USER = 'ATBM_QLNV' THEN
        role_R := 'DBA';
        RETURN;
    END IF;
END;
/
GRANT EXECUTE ON SP_GET_DB_ROLE TO PUBLIC;
/

------------------------------------------------------------------------------------------------------------------------------------------
-- 1) Xem danh sách ngý?i dùng trong h? th?ng.
-- 2) Thông tin v? quy?n (privileges) c?a m?i user/ role trên các ð?i tý?ng d? li?u.
-- 3) Cho phép t?o m?i, xóa, s?a (hi?u ch?nh) user ho?c role.
-- 4) Cho phép th?c hi?n vi?c c?p quy?n: 
--     c?p quy?n cho user, c?p quy?n cho role, c?p role cho user. 
--     Quá tr?nh c?p quy?n có tùy ch?n là có cho phép ngý?i ðý?c c?p quy?n có th? c?p quy?n ðó cho user/ role khác hay không 
--     (có ch? ð?nh WITH GRANT OPTION hay không). 
--     Quy?n, select, update th? cho phép phân quy?n tinh ð?n m?c c?t; quy?n insert, delete th? không.
-- 5) Cho phép thu h?i quy?n t? ngý?i dùng/ role.
-- 6) Cho phép ki?m tra quy?n c?a các ch? th? v?a ðý?c c?p quy?n.
-- 7) Cho phép ch?nh s?a quy?n c?a user/ role.
------------------------------------------------------------------------------------------------------------------------------------------

-- Hi?n th? danh sách ngý?i dùng trong h? th?ng.
CREATE OR REPLACE PROCEDURE SP_VIEW_LIST_USER(
    O_CURSOR OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN O_CURSOR FOR 
    SELECT USERNAME, USER_ID, CREATED
    FROM ALL_USERS
    WHERE CREATED >= TO_DATE('23-03-21', 'YY-MM-DD')
    ORDER BY USER_ID;
    
END;
/

-- Test
VARIABLE RCL REFCURSOR;
--EXEC ATBM_QLNV.SP_VIEW_LIST_USER(:RCL);
EXEC SP_VIEW_LIST_USER(:RCL);
PRINT RCL; 

-- Hi?n th? danh sách ngý?i dùng & role trong h? th?ng.
CREATE OR REPLACE PROCEDURE SP_VIEW_USER_ROLE(
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR 
    SELECT 'USER' USERTYPE, USERNAME
	FROM ALL_USERS
	WHERE CREATED >= TO_DATE('23-03-21', 'YY-MM-DD')
	UNION
	SELECT 'ROLE' USERTYPE, ROLE
	FROM SYS.DBA_ROLES
	WHERE ROLE LIKE 'ROLE%';
END;
/

-- Test
VARIABLE RCL REFCURSOR;
EXEC SP_VIEW_USER_ROLE(:RCL);
PRINT RCL; 

-- Hi?n th? danh sách CÁC OBJECT trong h? th?ng.
CREATE OR REPLACE PROCEDURE SP_VIEW_LIST_OBJECT(
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT OBJECT_NAME, OBJECT_TYPE
    FROM USER_OBJECTS;
END;
/

-- Test
VARIABLE RCL REFCURSOR;
EXEC SP_VIEW_LIST_OBJECT(:RCL);
PRINT RCL; 

-- Hi?n th? danh sách CÁC TABLE trong h? th?ng.
CREATE OR REPLACE PROCEDURE SP_VIEW_LIST_TABLE(
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT OBJECT_NAME
    FROM USER_OBJECTS
	WHERE OBJECT_TYPE = 'TABLE';
END;
/

-- Test
VARIABLE RCL REFCURSOR;
EXEC SP_VIEW_LIST_TABLE(:RCL);
PRINT RCL; 

-- Hi?n th? danh sách tên các Column c?a Table (Do user ATBM_QLNV t?o) ðý?c truy?n vào.
CREATE OR REPLACE PROCEDURE SP_VIEW_COLUMN_OF_TABLE(
    I_TABLE_NAME VARCHAR2, 
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT COLUMN_NAME 
    FROM ALL_TAB_COLUMNS
    WHERE OWNER = 'ATBM_QLNV' AND TABLE_NAME = I_TABLE_NAME;
END;
/

-- Hi?n th? danh sách CÁC ROLE trong h? th?ng (Do user ATBM_QLNV t?o, d?ng "ROLE%").
CREATE OR REPLACE PROCEDURE SP_VIEW_LIST_ROLE(
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT ROLE
    FROM SYS.DBA_ROLES
    WHERE ROLE LIKE 'ROLE%';
END;
/

-- Test
VARIABLE RCL REFCURSOR;
EXEC SP_VIEW_LIST_ROLE(:RCL);
PRINT RCL; 

-- Hi?n th? danh sách các quy?n c?a user (Do user ATBM_QLNV t?o).
CREATE OR REPLACE PROCEDURE SP_VIEW_LIST_PRIVILEGE(
    O_CURSOR OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT GRANTEE, TABLE_NAME "OBJECT_NAME", '' "COLUMN", PRIVILEGE, GRANTABLE, TYPE
    FROM DBA_TAB_PRIVS
    WHERE OWNER = 'ATBM_QLNV' AND PRIVILEGE NOT IN ('INSERT', 'UPDATE')
    
    UNION 
    SELECT GRANTEE, TABLE_NAME "OBJECT_NAME", COLUMN_NAME "COLUMN", PRIVILEGE, GRANTABLE, 'TABLE' "TYPE"
    FROM DBA_COL_PRIVS
    WHERE OWNER = 'ATBM_QLNV'
    
    UNION
    SELECT GRANTEE, GRANTED_ROLE "OBJECT_NAME", '' "COLUMN", '' "PRIVILEGE", '' "GRANTABLE", 'ROLE' "TYPE"
    FROM DBA_ROLE_PRIVS
    WHERE GRANTED_ROLE LIKE 'ROLE_%'
    
    ORDER BY GRANTEE ASC, OBJECT_NAME ASC, PRIVILEGE ASC;
END;
/

-- Test
VARIABLE RCL REFCURSOR;
EXEC SP_VIEW_LIST_PRIVILEGE(:RCL);
PRINT RCL; 



--FORM3----------------------------------------------------------------------------------------------------------------------------------------
-- PROC#1: SP_EDIT_PRIVILEGE_TO_USER: 
-- input:
    -- I_CMD
    -- I_USER
    -- I_OBJECT
    -- I_PRIVILEGE_TYPE
    -- I_COLUMN_LIST
    -- I_GRANT_OPTION
-- output: 
    -- GRANT EXECUTE                        ON I_OBJECT TO I_USER/I_ROLE (WITH GRANT OPTION);
    -- GRANT SELECT/DELETE                  ON I_OBJECT TO I_USER/I_ROLE (WITH GRANT OPTION);
    -- GRANT UPDATE/INSERT (I_COLUMN_LIST)  ON I_OBJECT TO I_USER/I_ROLE (WITH GRANT OPTION);
    
    -- REVOKE EXECUTE                       ON I_OBJECT TO I_USER/I_ROLE;
    -- REVOKE SELECT/DELETE/UPDATE/INSERT   ON I_OBJECT TO I_USER/I_ROLE;
------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE PROCEDURE SP_EDIT_PRIVILEGE_TO_USER
(
    I_CMD   IN VARCHAR2,    --GRANT/REVOKE
    I_USER  IN VARCHAR2,    -- USER/ROLE
    I_OBJECT IN VARCHAR2,   -- TABLE/VIEW/PROCEDURE/FUNCTION/...
    I_PRIVILEGE_TYPE IN VARCHAR2, -- SELECT/UPDATE/INSERT/DELETE/EXEC
    I_COLUMN_LIST IN VARCHAR2, -- COLUMN1, COLUMN2,...
    I_GRANT_OPTION IN BOOLEAN
) IS
    P_QUERY VARCHAR2(1000);
BEGIN
    P_QUERY := I_CMD || ' ';
        
    -- SELECT/DELETE/EXECUTE ON I_OBJECT (OR REVOKE)
    IF I_CMD = 'REVOKE' OR I_PRIVILEGE_TYPE = 'SELECT' OR I_PRIVILEGE_TYPE = 'DELETE' OR I_PRIVILEGE_TYPE = 'EXECUTE' THEN
        P_QUERY := P_QUERY || I_PRIVILEGE_TYPE || ' ON ATBM_QLNV.' || I_OBJECT;

    --UPDATE/INSERT(I_COLUMN_LIST) ON I_OBLECT (TABLE)
    ELSIF I_PRIVILEGE_TYPE = 'UPDATE' OR I_PRIVILEGE_TYPE = 'INSERT' THEN  
        P_QUERY := P_QUERY || I_PRIVILEGE_TYPE;
        IF I_COLUMN_LIST IS NOT NULL THEN
            P_QUERY := P_QUERY || ' (' || I_COLUMN_LIST || ')';
        END IF;          
        P_QUERY := P_QUERY || ' ON ATBM_QLNV.' || I_OBJECT;       
    END IF;

    -- TO I_USER
    IF I_CMD = 'GRANT' THEN
        P_QUERY := P_QUERY || ' TO ' || I_USER;
    ELSE
        P_QUERY := P_QUERY || ' FROM ' || I_USER;
    END IF;

    -- WITH GRANT OPTION
    IF I_CMD = 'GRANT' AND I_GRANT_OPTION THEN
        P_QUERY := P_QUERY || ' WITH GRANT OPTION';
    END IF;
    
    DBMS_OUTPUT.PUT_LINE(P_QUERY);
    EXECUTE IMMEDIATE P_QUERY;

EXCEPTION
    WHEN OTHERS THEN  -- handles all other errors
        ROLLBACK;
END;
/

-- Test
DECLARE
    I_CMD VARCHAR2(30);
    I_USER VARCHAR2(30);
    I_OBJECT VARCHAR2(30);
    I_PRIVILEGE_TYPE VARCHAR2(30);
    I_COLUMN_LIST VARCHAR2(30);
    I_GRANT_OPTION BOOLEAN;

BEGIN
    I_CMD := 'REVOKE';
    I_USER := 'I_USER';
    I_OBJECT := 'abc_PROCEDURE';
    I_PRIVILEGE_TYPE := 'UPDATE';
    I_COLUMN_LIST := 'I_COLUMN_LIST';
    I_GRANT_OPTION := TRUE;

    SP_EDIT_PRIVILEGE_TO_USER(I_CMD, I_USER, I_OBJECT, I_PRIVILEGE_TYPE, I_COLUMN_LIST, I_GRANT_OPTION);
END;
/

--FORM3----------------------------------------------------------------------------------------------------------------------------------------
-- PROC#2: SP_GRANT_ROLE_TO_USER
-- input:
    -- I_USER: USERNAME
    -- I_ROLE: ROLENAME
-- output:
-- GRANT I_ROLE TO I_USER
------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE PROCEDURE SP_EDIT_ROLE_TO_USER(
    I_CMD  	IN VARCHAR2,    --GRANT/REVOKE
    I_USER 	IN VARCHAR2,
    I_ROLE 	IN VARCHAR2
) IS
    P_QUERY VARCHAR2(1000);
BEGIN
    P_QUERY := I_CMD || ' ' || I_ROLE;
    
    -- TO I_USER
    IF I_CMD = 'GRANT' THEN
        P_QUERY := P_QUERY || ' TO ' || I_USER;
    ELSE
        P_QUERY := P_QUERY || ' FROM ' || I_USER;
    END IF;
    
    DBMS_OUTPUT.PUT_LINE(P_QUERY);
    EXECUTE IMMEDIATE P_QUERY;
END;
/

 
--FORM1----------------------------------------------------------------------------------------------------------------------------------------
-- PROC#3: SP_CREATE_USER
-- input:
    -- I_USERNAME: USERNAME
    -- I_PASSWORD: PASSWORD
-- output:
-- CREATE USER I_USER IDENTIFIED BY I_PASSWORD / NOT IDENTIFIED
------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE PROCEDURE SP_CREATE_USER(
    I_USERNAME IN VARCHAR2,
    I_PASSWORD IN VARCHAR2
) IS
    P_QUERY VARCHAR2(1000);
BEGIN
    P_QUERY := 'CREATE USER ' || I_USERNAME;
    IF I_PASSWORD IS NOT NULL THEN
        P_QUERY := P_QUERY || ' IDENTIFIED BY ' || I_PASSWORD;
    ELSE
        P_QUERY := P_QUERY || ' NOT IDENTIFIED';
    END IF;
    DBMS_OUTPUT.PUT_LINE(P_QUERY);
    
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE P_QUERY;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || I_USERNAME;
--EXCEPTION
--    WHEN OTHERS THEN  -- handles all other errors
--        ROLLBACK;
END;
/

--FORM1----------------------------------------------------------------------------------------------------------------------------------------
-- PROC#4: SP_CREATE_ROLE
-- input:
    -- I_ROLENAME: ROLENAME
    -- I_PASSWORD: PASSWORD
-- output:
-- CREATE ROLE I_ROLENAME IDENTIFIED BY I_PASSWORD / NOT IDENTIFIED
------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE PROCEDURE SP_CREATE_ROLE(
    I_ROLENAME IN VARCHAR2
) IS
    P_QUERY VARCHAR2(1000);
BEGIN
    P_QUERY := 'CREATE ROLE ' || I_ROLENAME || ' NOT IDENTIFIED';

    DBMS_OUTPUT.PUT_LINE(P_QUERY);
    
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE P_QUERY;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || I_ROLENAME;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || I_ROLENAME;
--EXCEPTION
--    WHEN OTHERS THEN  -- handles all other errors
--        ROLLBACK;
END;
/


--FORM1----------------------------------------------------------------------------------------------------------------------------------------
-- PROC#5: SP_DROP_USER
-- input:
    -- I_USERNAME: USERNAME
-- output:
-- DROP USER I_USER
------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE PROCEDURE SP_DROP_USER(
    I_USERTYPE IN VARCHAR2,
    I_USERNAME IN VARCHAR2
) IS
    P_QUERY VARCHAR2(1000);
BEGIN
    IF I_USERTYPE = 'USER' THEN
        P_QUERY := 'DROP USER ';
    ELSE
        P_QUERY := 'DROP ROLE ';
    END IF;
     
    P_QUERY := P_QUERY || I_USERNAME;
    DBMS_OUTPUT.PUT_LINE(P_QUERY);
    
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE P_QUERY;
--EXCEPTION
--    WHEN OTHERS THEN  -- handles all other errors
--        ROLLBACK;
END;
/

--Proc phan quyen he thong cho user/role
CREATE OR REPLACE PROCEDURE SP_GRANT_SYS_PRIVS
(PRIVS IN VARCHAR2,
SUBJECT IN VARCHAR2,
WITH_GRANT_OPTION IN INT)
AS
    Q VARCHAR2(1000);
BEGIN
    Q := 'GRANT '||PRIVS||' TO '||SUBJECT;
    IF (WITH_GRANT_OPTION = 1) THEN
        Q := Q || ' WITH ADMIN OPTION';
    END IF;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE Q;
END;
/

--Proc phan quyen doi tuong cho user/role
CREATE OR REPLACE PROCEDURE SP_GRANT_TAB_PRIVS
(PRIVS IN VARCHAR2,
SUBJECT IN VARCHAR2,
OBJ IN VARCHAR2,
WITH_GRANT_OPTION IN INT)
AS
    Q VARCHAR2(1000);
BEGIN
    Q := 'GRANT '||PRIVS||' ON '||OBJ||' TO '||SUBJECT;
    IF (WITH_GRANT_OPTION = 1) THEN
        Q := Q || ' WITH GRANT OPTION';
    END IF;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE Q;
END;
/
--Proc xem quyen he thong cua user/role
CREATE OR REPLACE PROCEDURE SP_VIEW_SYS_PRIVILEGE(
    I_SUBJECT  VARCHAR2,
    O_CURSOR    OUT SYS_REFCURSOR
) IS
BEGIN    
    OPEN O_CURSOR FOR
    SELECT GRANTEE AS "SUBJECT", PRIVILEGE, ADMIN_OPTION
    FROM DBA_SYS_PRIVS
    WHERE GRANTEE = I_SUBJECT
    
    UNION
    SELECT ROLE AS "SUBJECT", PRIVILEGE, ADMIN_OPTION
    FROM ROLE_SYS_PRIVS
    WHERE ROLE = I_SUBJECT
    
    ORDER BY PRIVILEGE ASC;
END;
/
--Proc xem quyen doi tuong cua user/role
CREATE OR REPLACE PROCEDURE SP_VIEW_TAB_PRIVILEGE(
    I_SUBJECT  VARCHAR2,
    O_CURSOR    OUT SYS_REFCURSOR
) IS
BEGIN
    OPEN O_CURSOR FOR
    SELECT GRANTEE, TABLE_NAME "OBJECT_NAME", '' "COLUMN", PRIVILEGE, GRANTABLE, TYPE
    FROM DBA_TAB_PRIVS
    WHERE GRANTEE = I_SUBJECT
    
    UNION 
    SELECT GRANTEE, TABLE_NAME "OBJECT_NAME", COLUMN_NAME "COLUMN", PRIVILEGE, GRANTABLE, 'TABLE' "TYPE"
    FROM DBA_COL_PRIVS
    WHERE GRANTEE = I_SUBJECT
    
    UNION
    SELECT GRANTEE, GRANTED_ROLE "OBJECT_NAME", '' "COLUMN", '' "PRIVILEGE", '' "GRANTABLE", 'ROLE' "TYPE"
    FROM DBA_ROLE_PRIVS
    WHERE GRANTED_ROLE LIKE 'ROLE%' AND GRANTEE = I_SUBJECT
    
    UNION
    SELECT ROLE, TABLE_NAME "OBJECT_NAME", COLUMN_NAME "COLUMN", PRIVILEGE, GRANTABLE, '' "TYPE"
    FROM ROLE_TAB_PRIVS
    WHERE ROLE = I_SUBJECT
    
    ORDER BY OBJECT_NAME ASC, PRIVILEGE ASC;
END;
/

