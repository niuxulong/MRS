using Common.Enums;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Interfaces
{
    public interface ICaseHistoryModel
    {
        bool UpdateCaseHistoryStatus(Guid caseHistoryId, Enums.CaseHistoryStatus status);

        bool InsertCaseHistory(CaseHistory caseHistory);

        List<CaseHistory> GetCaseHistoryByPatientId(string patientId);
    }
}
