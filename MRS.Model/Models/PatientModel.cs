using Common.DataBaseAccessor;
using MRS.Entity.Entities;
using MRS.Model.Const;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
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

        public List<Patient> GetPatientsByName(string name)
        {
            try
            {
                var results = new List<Patient>();
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTPATIENTS, name);

                return results;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
