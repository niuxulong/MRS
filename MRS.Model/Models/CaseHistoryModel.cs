﻿using Common.Const;
using Common.DataBaseAccessor;
using Common.Enums;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace MRS.Model.Models
{
    public class CaseHistoryModel : ICaseHistoryModel 
    {
        public bool DeleteCaseHistory(Guid caseHistoryId)
        {
            try
            {
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_DELETECASEHISTORY, caseHistoryId.ToString());
                return rowAmount > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCaseHistoryStatus(Guid caseHistoryId, Enums.CaseHistoryStatus status)
        {
            try
            {
                var rowAmount = SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), SqlConst.SP_UPDATECASEHISTORYSTATUS, new object[] { caseHistoryId.ToString(), (int)status });
                return rowAmount > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CaseHistory> GetCaseHistoryByPatientId(string patientId)
        {
            try
            {
                var results = new List<CaseHistory>();
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTCASEHISTORY, patientId);
                return ConvertToCaseHistoryList(dataSet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertCaseHistory(CaseHistory caseHistory)
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
            var caseHistoryParams = new object[8];
            caseHistoryParams[0] = caseHistory.Id.ToString();
            caseHistoryParams[1] = caseHistory.PatientId;
            caseHistoryParams[2] = caseHistory.FileName;
            caseHistoryParams[3] = caseHistory.FileTitle;
            caseHistoryParams[4] = caseHistory.FileContent;
            caseHistoryParams[5] = caseHistory.CreatedBy;
            caseHistoryParams[6] = caseHistory.CreatedById;
            caseHistoryParams[7] = caseHistory.CaseType;
            return caseHistoryParams;
        }

        private List<CaseHistory> ConvertToCaseHistoryList(DataSet dataSet)
        {
            List<CaseHistory> results = new List<CaseHistory>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var caseHistory = new CaseHistory();
                caseHistory.Id = System.Guid.Parse(dataRow.ItemArray[0].ToString());
                caseHistory.PatientId = dataRow.ItemArray[1].ToString();
                caseHistory.FileName = dataRow.ItemArray[2].ToString();
                caseHistory.FileTitle = dataRow.ItemArray[3].ToString();
                caseHistory.FileContent = dataRow.ItemArray[4].ToString();
                caseHistory.CreatedById = dataRow.ItemArray[12].ToString();
                caseHistory.CreatedBy = dataRow.ItemArray[13].ToString();
                caseHistory.Status = (int)dataRow.ItemArray[14];
                caseHistory.CaseType = (int)dataRow.ItemArray[15];
                results.Add(caseHistory);
            }

            return results;
        }
    }
}
