using MRS.Entity.Entities;
using System;
using System.Collections.Generic;

namespace Common.EventArguments
{
    public class SystemConfigEventArgs: EventArgs
    {
        public DatabaseConfig DatabaseConfig { get; set; }

        public List<TemplateCatalogNode> TemplateCatalogNodes { get; set; }
    }
}
