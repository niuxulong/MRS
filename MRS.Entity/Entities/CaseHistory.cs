using System;

namespace MRS.Entity.Entities
{
    public class CaseHistory
    {
        public Guid Id { get; set; }

        public string PatientId { get; set; }

        public string FileName { get; set; }

        public string FileTitle { get; set; }

        public string FileContent { get; set; }

        public string CreatedById { get; set; }

        public string CreatedBy { get; set; }
    }
}
