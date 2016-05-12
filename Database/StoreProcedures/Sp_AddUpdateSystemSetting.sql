IF(EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME='Sp_AddUpdateSystemSetting'))
	DROP PROCEDURE Sp_AddUpdateSystemSetting
GO

CREATE PROCEDURE [dbo].[Sp_AddUpdateSystemSetting]
	@Id int,
	@key nvarchar(max),
	@value nvarchar(max)
AS
	IF(EXISTS(SELECT * FROM EMR_SYSTEMSETTING WHERE Id = @Id))
		UPDATE EMR_SYSTEMSETTING SET Value = @value
	ELSE
		INSERT EMR_SYSTEMSETTING(Id, SettingKey, Value) VALUES (@Id, @key, @value)
GO
 
