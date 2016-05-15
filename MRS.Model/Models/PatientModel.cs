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
    public class PatientModel : IPatientModel
    {
        public PatientModel()
        {

        }

        public string GetConnSting(string serverName, string dataBaseName, string uid, string pwd)
        {
            return "server=" + serverName + ";database=" + dataBaseName + ";uid=" + uid + ";pwd=" + pwd;
        }

        public List<Patient> GetPatientsByName(string name = null)
        {
            try
            {
                var results = new List<Patient>();
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTPATIENTS, name);
                return ConvertToPatientsList(dataSet);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private List<Patient> ConvertToPatientsList(DataSet dataSet)
        {
            List<Patient> results = new List<Patient>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            { 
                var patient = new Patient();
                patient.PatientId = dataRow.ItemArray[0].ToString();
                patient.BeinHospitalCode = dataRow.ItemArray[1].ToString();
                patient.Name = dataRow.ItemArray[2].ToString();
                patient.Sex = dataRow.ItemArray[3].ToString();
                patient.PrithTime = dataRow.ItemArray[4].ToString();

                results.Add(patient);
            }

            return results;
        }
    }
}
