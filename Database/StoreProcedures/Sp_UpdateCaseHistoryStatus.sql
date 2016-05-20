IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_UpdateCaseHistoryStatus'))
	DROP PROCEDURE Sp_UpdateCaseHistoryStatus
GO

CREATE PROCEDURE [dbo].[Sp_UpdateCaseHistoryStatus]
	@Id nvarchar(max),
	@Status int
AS
	UPDATE EMR_CASEHISTORY SET STATUS = @Status WHERE RECORDID = @Id
GO
