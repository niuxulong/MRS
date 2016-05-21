IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_InsertCaseHistory'))
	DROP PROCEDURE Sp_InsertCaseHistory
GO

CREATE PROCEDURE [dbo].[Sp_InsertCaseHistory]
	@RecordId nvarchar(100),
	@PatientId nvarchar(50),
	@FileName nvarchar(500),
	@FileTitle nvarchar(400),
	@FileContent ntext,
	@CreatedById nvarchar(100),
	@CreatedBy nvarchar(100),
	@CaseType int
AS
IF(EXISTS(SELECT * FROM EMR_CASEHISTORY WHERE RECORDID = @RecordId))
	UPDATE EMR_CASEHISTORY SET FILENAME = @FileName, FILECONTENT = @FileContent, CASETYPE = @CaseType WHERE RECORDID = @RecordId
ELSE
BEGIN
INSERT EMR_CASEHISTORY(
			RECORDID, 
			PA_ID, 
			FILENAME, 
			FILETITLE, 
			FILECONTENT, 
			CREATEDBYID, 
			CREATEDBY,
			STATUS,
			CASETYPE) 
		VALUES (
			@RecordId, 
			@PatientId, 
			@FileName, 
			@FileTitle, 
			@FileContent, 
			@CreatedById, 
			@CreatedBy,
			0,
			@CaseType)
END

		
GO