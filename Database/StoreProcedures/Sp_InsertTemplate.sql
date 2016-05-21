IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_InsertTemplate'))
	DROP PROCEDURE Sp_InsertTemplate
GO

CREATE PROCEDURE [dbo].[Sp_InsertTemplate]
	@recordId nvarchar(max),
	@parentId nvarchar(max),
	@fileName nvarchar(max),
	@fileContent nvarchar(max),
	@CreatedById nvarchar(100),
	@CreatedBy nvarchar(100),
	@TemplateAttr int
AS
		
		INSERT EMR_TEMPLATE(
			RECORDID, 
			PARENTID, 
			FILENAME, 
			FILECONTENT, 
			CREATEDBYID, 
			CREATEDBY,
			TemplateAttr)
		VALUES (
		@RecordId, 
		@parentId, 
		@FileName, 
		@FileContent, 
		@CreatedById, 
		@CreatedBy,
		@TemplateAttr)
GO