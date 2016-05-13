using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenters.Presenter
{
    public class SearchPatientPresenter : Presenter<ISearchPatientView>
    {
        public IPatientModel patientModel { get; private set; }

        public SearchPatientPresenter(ISearchPatientView view)
            : base(view)
        {
            this.patientModel = new PatientModel();
        }

        protected override void OnViewSet()
        {
            this.View.SearchPatientEvent += HandleSearchPatientEvent;
        }

        private void HandleSearchPatientEvent(object sender, string name)
        {
            var patientName = string.IsNullOrEmpty(name) ? null : name;
            var patients = this.patientModel.GetPatientsByName(patientName);
            this.View.PopulatePatientsRecords(patients);
        }
    }
}
