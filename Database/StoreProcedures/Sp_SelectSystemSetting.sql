CREATE PROCEDURE [dbo].[Sp_SelectSystemSetting]
AS
	SELECT Id, SettingKey, Value FROM EMR_SYSTEMSETTING
GO