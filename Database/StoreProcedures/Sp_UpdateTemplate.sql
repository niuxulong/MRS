IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_UpdateTemplate'))
	DROP PROCEDURE Sp_UpdateTemplate
GO

CREATE PROCEDURE [dbo].[Sp_UpdateTemplate]
	@recordId nvarchar(max),
	@parentId nvarchar(max),
	@fileName nvarchar(max),
	@fileContent nvarchar(max)
AS
		UPDATE EMR_TEMPLATE SET FILENAME=@fileName, FILECONTENT=@fileContent WHERE RECORDID = @recordId
GO