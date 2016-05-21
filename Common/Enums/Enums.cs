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

            //病程
            ProgressNote = 1,

            //首日病程
            FirstProgressNote = 2
        }

        public enum CaseHistoryStatus
        { 
            New = 0, //新建病历

            Checking = 1, //审核中

            Checked = 2, //审核完毕

            Finalized = 3 //归档
        }
    }
}
