﻿IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_SelectTemplate'))
	DROP PROCEDURE Sp_SelectTemplate
GO

CREATE PROCEDURE [dbo].[Sp_SelectTemplate]
AS
	SELECT RECORDID, FILENAME, FILETITLE, FILECONTENT FROM EMR_TEMPLATE
GO
 