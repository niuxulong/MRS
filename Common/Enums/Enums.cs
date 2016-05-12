using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
