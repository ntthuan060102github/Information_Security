CONNECT ATBM_QLNV/team18@//localhost:1521/ATBM_QLNV_PDB;
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;

CREATE TABLE KEY_STORAGE (
    ID NUMBER GENERATED ALWAYS AS IDENTITY,
    KEY_VALUE VARCHAR2(100) NOT NULL,
    CONSTRAINT KEY_STORAGE_PK PRIMARY KEY (ID)
);

