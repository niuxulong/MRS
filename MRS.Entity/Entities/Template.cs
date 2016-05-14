using System;

namespace MRS.Entity.Entities
{
    public class Template
    {

        public Guid RecordId { get; set; }

        public string FileName { get; set; }

        public string FileTitle { get; set; }

        public string FileContent { get; set; }

        public int ParentNodeId { get; set; }

        public string CreatedById { get; set; }

        public string CreatedBy { get; set; }

        public int TemplateAttr { get; set; }
    }
}
