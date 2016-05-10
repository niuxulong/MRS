using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenter.Presenters
{
    public class PatientPresenter : IPatientPresenter
    {
        private IPatientModel patientModel;

        public PatientPresenter()
        {
            patientModel = new PatientModel();
        }

        public List<Patient> GetPatientsByName(string name)
        {
            var results = patientModel.GetPatientsByName(name);
            return null;
        }
    }
}
