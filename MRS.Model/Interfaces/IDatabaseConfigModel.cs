using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Interfaces
{
    public interface IDatabaseConfigModel
    {
        bool UpdateOrAddDatabaseConfig(DatabaseConfig config);

        bool DeleteDatabaseConfig();
    }
}
