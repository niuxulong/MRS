using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.EventArguments
{
    public class SystemConfigEventArgs: EventArgs
    {
        public DatabaseConfig DatabaseConfig { get; set; }

        public List<TemplateCatalogNode> TemplateCatalogNodes { get; set; }
    }
}
