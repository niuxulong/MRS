using Common.Const;
using Common.DataBaseAccessor;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Models
{
    public class CaseHistoryModel : ICaseHistoryModel 
    {
        public bool InsertCasaHistory(CaseHistory caseHistory)
        {
            try
            {
                var rowCount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_INSERTCASEHISTORY, ConvertToParamDataRow(caseHistory));
                return rowCount > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private object[] ConvertToParamDataRow(CaseHistory caseHistory)
        {
            var caseHistoryParams = new object[7];
            caseHistoryParams[0] = caseHistory.Id.ToString();
            caseHistoryParams[1] = caseHistory.PatientId;
            caseHistoryParams[2] = caseHistory.FileName;
            caseHistoryParams[3] = caseHistory.FileTitle;
            caseHistoryParams[4] = caseHistory.FileContent;
            caseHistoryParams[5] = caseHistory.CreatedBy;
            caseHistoryParams[6] = caseHistory.CreatedById;

            return caseHistoryParams;
        }
    }
}
