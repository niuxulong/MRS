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
            Common = 0,
            ProgressNote = 1,
            FirstProgressNote = 2
        }
    }
}
