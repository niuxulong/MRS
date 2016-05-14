using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using Common.Utility;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Models
{
    public class DatabaseConfigModel : SystemConfigBaseModel<DatabaseConfig>, IDatabaseConfigModel
    {
        public DatabaseConfigModel()
        {
            
        }

        public DatabaseConfig GetDatabaseConfig()
        {
            return this.GetSystemConfig(Enums.SystemSettingKeyEnum.DataBaseConnection);
        }

        public bool UpdateOrAddDatabaseConfig(DatabaseConfig config)
        {
            return this.UpdateOrAddSystemConfig(config, Enums.SystemSettingIdEnum.DataBaseConnectionId, Enums.SystemSettingKeyEnum.DataBaseConnection, config);
        }

        public bool DeleteDatabaseConfig()
        {
            return this.DeleteSystemConfig(Enums.SystemSettingIdEnum.DataBaseConnectionId, Enums.SystemSettingKeyEnum.DataBaseConnection);
        }
    }
}
