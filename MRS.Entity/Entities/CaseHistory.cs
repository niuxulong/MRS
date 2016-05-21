using System;
namespace MRS.Entity.Entities
{
    public class CaseHistory : ICloneable
    {
        public Guid Id { get; set; }

        public string PatientId { get; set; }

        public string FileName { get; set; }

        public string FileTitle { get; set; }

        public string FileContent { get; set; }

        public string CreatedById { get; set; }

        public string CreatedBy { get; set; }

        public int CaseType { get; set; }

        // 用于UI
        public object Tag { get; set; }

        public int Status { get; set; }

        public object Clone()
        {
            CaseHistory newCaseHistory = new CaseHistory();
            newCaseHistory.Id = Id;
            newCaseHistory.PatientId = PatientId;
            newCaseHistory.FileName = FileName;
            newCaseHistory.FileTitle = FileTitle;
            newCaseHistory.FileContent = FileContent;
            newCaseHistory.CaseType = CaseType;
            newCaseHistory.CreatedById = CreatedById;
            newCaseHistory.CreatedBy = CreatedBy;
            return newCaseHistory;
        }
    }
}
