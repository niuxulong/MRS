using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.EventArguments
{
    public class UpdateCaseHistoryStatusEventArgs : EventArgs
    {
        public Guid caseHistoryId { get; set; }

        public Enums.Enums.CaseHistoryStatus status { get; set; }

        public string PatientId { get; set; }
    }
}
