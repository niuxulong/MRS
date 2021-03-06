CREATE TABLE [dbo].[EMR_CASEHISTORY]
(
	[RECORDID] NVARCHAR(100) NOT NULL PRIMARY KEY, 
    [PA_ID] NVARCHAR(50) NOT NULL, 
    [FILENAME] NVARCHAR(500) NULL, 
    [FILETITLE] NVARCHAR(400) NULL, 
    [FILECONTENT] NTEXT NULL, 
    [FILEFORMAT] NVARCHAR(100) NULL, 
    [DEPARTMENTID] NVARCHAR(100) NULL, 
    [TEMPLATETYPE] NVARCHAR(100) NULL, 
    [KEYDATANAMES] NVARCHAR(2000) NULL, 
    [TEMPLATEFLAGS] NUMERIC(38) NULL, 
    [OWNERID] NVARCHAR(100) NULL, 
    [OWNERLEVEL] NVARCHAR(100) NULL, 
    [CREATEDBYID] NVARCHAR(100) NULL, 
    [CREATEDBY] NVARCHAR(100) NULL, 
    [STATUS] INT NULL, 
    [CASETYPE] INT NULL,
	[PROGRESSLEVEL] INT NULL
)
