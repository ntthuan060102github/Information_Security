SET WRAP OFF;
CONNECT LBACSYS/LBACSYS@//localhost:1521/ATBM_QLNV_PDB;

BEGIN
    SA_SYSDBA.DROP_POLICY(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26'
    );
EXCEPTION
    WHEN OTHERS THEN RETURN;
END;
/

EXECUTE SA_SYSDBA.CREATE_POLICY('ATBM_QLNV_OLS_TEST26', 'ROW_LABEL');

--CREATE 3 LEVELS
BEGIN
    SA_COMPONENTS.CREATE_LEVEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LEVEL_NUM => 100,
        SHORT_NAME => 'L_NV',
        LONG_NAME => 'NHAN_VIEN'
    );
        
    SA_COMPONENTS.CREATE_LEVEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LEVEL_NUM => 200,
        SHORT_NAME => 'L_TP',
        LONG_NAME => 'TRUONG_PHONG'
    );
        
    SA_COMPONENTS.CREATE_LEVEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LEVEL_NUM => 300,
        SHORT_NAME => 'L_BGD',
        LONG_NAME => 'BAN_GIAM_DOC'
    );
END;
/

--CREATE 3 COMPARTMENTS
BEGIN
    SA_COMPONENTS.CREATE_COMPARTMENT(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        COMP_NUM => 110,
        SHORT_NAME => 'C_MB',
        LONG_NAME => 'MUA_BAN'
    );
        
    SA_COMPONENTS.CREATE_COMPARTMENT(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        COMP_NUM => 120,
        SHORT_NAME => 'C_SX',
        LONG_NAME => 'SAN_XUAT'
    );
        
    SA_COMPONENTS.CREATE_COMPARTMENT(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        COMP_NUM => 130,
        SHORT_NAME => 'C_GC',
        LONG_NAME => 'GIA_CONG'
    );
END;
/

--CREATE 4 GROUPS
BEGIN
    SA_COMPONENTS.CREATE_GROUP(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        GROUP_NUM => 1,
        SHORT_NAME => 'G_TQ',
        LONG_NAME => 'TOAN_QUOC',
        PARENT_NAME => NULL
    );

    SA_COMPONENTS.CREATE_GROUP(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        GROUP_NUM => 400,
        SHORT_NAME => 'G_MB',
        LONG_NAME => 'MIEN_BAC',
        PARENT_NAME => 'G_TQ'
    );
        
    SA_COMPONENTS.CREATE_GROUP(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        GROUP_NUM => 450,
        SHORT_NAME => 'G_MT',
        LONG_NAME => 'MIEN_TRUNG',
        PARENT_NAME => 'G_TQ'
    );
        
    SA_COMPONENTS.CREATE_GROUP(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        GROUP_NUM => 500,
        SHORT_NAME => 'G_MN',
        LONG_NAME => 'MIEN_NAM',
        PARENT_NAME => 'G_TQ'
    );
END;
/

--CREATE LABELS
BEGIN
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 100,
        LABEL_VALUE => 'L_BGD:C_MB,C_SX,C_GC:G_TQ'
    );
    -----
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 110,
        LABEL_VALUE => 'L_BGD:C_MB,C_SX,C_GC:G_MB'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 120,
        LABEL_VALUE => 'L_BGD:C_MB,C_SX,C_GC:G_MT'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 130,
        LABEL_VALUE => 'L_BGD:C_MB,C_SX,C_GC:G_MN'
    );
    -----------------------------------------------
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 200,
        LABEL_VALUE => 'L_TP:C_MB:G_MB'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 210,
        LABEL_VALUE => 'L_TP:C_SX:G_MB'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 220,
        LABEL_VALUE => 'L_TP:C_GC:G_MB'
    );
    -----
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 230,
        LABEL_VALUE => 'L_TP:C_MB:G_MT'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 240,
        LABEL_VALUE => 'L_TP:C_SX:G_MT'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 250,
        LABEL_VALUE => 'L_TP:C_GC:G_MT'
    );
    -----
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 260,
        LABEL_VALUE => 'L_TP:C_MB:G_MN'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 270,
        LABEL_VALUE => 'L_TP:C_SX:G_MN'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 280,
        LABEL_VALUE => 'L_TP:C_GC:G_MN'
    );
    ------------------------------------
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 300,
        LABEL_VALUE => 'L_NV:C_MB:G_MB'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 310,
        LABEL_VALUE => 'L_NV:C_SX:G_MB'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 320,
        LABEL_VALUE => 'L_NV:C_GC:G_MB'
    );
    -----
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 330,
        LABEL_VALUE => 'L_NV:C_MB:G_MT'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 340,
        LABEL_VALUE => 'L_NV:C_SX:G_MT'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 350,
        LABEL_VALUE => 'L_NV:C_GC:G_MT'
    );
    -----
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 360,
        LABEL_VALUE => 'L_NV:C_MB:G_MN'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 370,
        LABEL_VALUE => 'L_NV:C_SX:G_MN'
    );
    SA_LABEL_ADMIN.CREATE_LABEL(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        LABEL_TAG => 380,
        LABEL_VALUE => 'L_NV:C_GC:G_MN'
    );
END;
/

SELECT * FROM ALL_SA_POLICIES;
SELECT * FROM ALL_SA_COMPARTMENTS;
SELECT * FROM ALL_SA_LEVELS;
SELECT * FROM ALL_SA_GROUPS;
SELECT * FROM ALL_SA_LABELS;
SELECT * FROM ALL_SA_POLICIES;

BEGIN
    SA_POLICY_ADMIN.REMOVE_TABLE_POLICY(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        SCHEMA_NAME => 'ATBM_QLNV',
        TABLE_NAME => 'THONGBAO',
        DROP_COLUMN => TRUE
    );
END;
/

BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        SCHEMA_NAME => 'ATBM_QLNV',
        TABLE_NAME => 'THONGBAO',
        TABLE_OPTIONS => 'READ_CONTROL'
    );
END;
/

BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        USER_NAME => 'TGD',
        MAX_READ_LABEL => 'L_BGD:C_MB,C_SX,C_GC:G_TQ'
    );
    SA_USER_ADMIN.SET_USER_LABELS(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        USER_NAME => 'GB_MB',
        MAX_READ_LABEL => 'L_BGD:C_MB,C_SX,C_GC:G_MB'
    );
    SA_USER_ADMIN.SET_USER_LABELS(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        USER_NAME => 'TP_SX_MN',
        MAX_READ_LABEL => 'L_TP:C_SX:G_MN'
    );
    SA_USER_ADMIN.SET_USER_LABELS(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        USER_NAME => 'TP_SX_MB',
        MAX_READ_LABEL => 'L_TP:C_SX:G_MB'
    );
    SA_USER_ADMIN.SET_USER_LABELS(
        POLICY_NAME => 'ATBM_QLNV_OLS_TEST26',
        USER_NAME => 'TP_GC_MN',
        MAX_READ_LABEL => 'L_TP:C_GC:G_MN'
    );
END;
