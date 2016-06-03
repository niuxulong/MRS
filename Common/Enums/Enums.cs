namespace Common.Enums
{
	public static class Enums
	{
		public enum SystemSettingKeyEnum
		{
			DataBaseConnection,

			TemplateCatalogNode
		}

		public enum SystemSettingIdEnum
		{
			DataBaseConnectionId = 0,

			TemplateCatalogNodeId = 1
		}

		public enum TemplateAttrEnum
		{
			Common = 0,

			Personal = 1,

			Undefined = 3
		}

		public enum CaseType
		{
			//普通病历
			Common = 0,

			//普通病程
			ProgressNote = 1,

			//首普通病程
			ProgressNoteWithFirstCommon = 2,

			//首中医病程
			ProgressNoteWithFirstTCM = 3
		}

		public enum CaseHistoryStatus
		{
			New = 0, //新建病历

			Checking = 1, //审核中

			Checked = 2, //审核完毕

			Finalized = 3 //归档
		}

		public enum TabPageType
		{
			CaseHistory = 0,

			Template = 1,

			ProgressNote = 2,

			FirstProgressCommonNote = 3,

			FirstTCMProgressNote = 4
		}
	}
}
