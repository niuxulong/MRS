using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Entity.Entities
{
    public class Template
    {

        public Guid RecordId { get; set; }

        public string FileName { get; set; }

        public string FileTitle { get; set; }

        public string FileContent { get; set; }
    }
}
