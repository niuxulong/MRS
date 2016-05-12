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
	@CreatedBy nvarchar(100)
AS
		INSERT EMR_CASEHISTORY(RECORDID, PA_ID, FILENAME, FILETITLE, FILECONTENT, CREATEDBYID, CREATEDBY) VALUES (@RecordId, @PatientId, @FileName, @FileTitle, @FileContent, @CreatedById, @CreatedBy)
GO