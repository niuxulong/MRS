using System.Collections.Generic;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System.Linq;
namespace MRS.Presenters.Presenter
{
	public class SearchPatientPresenter : Presenter<ISearchPatientView>
	{
		public IPatientModel patientModel { get; private set; }
		public ICaseHistoryModel caseHistoryModel { get; private set; }

		public SearchPatientPresenter(ISearchPatientView view)
			: base(view)
		{
			this.patientModel = new PatientModel();
			this.caseHistoryModel = new CaseHistoryModel();
		}

		protected override void OnViewSet()
		{
			this.View.SearchPatientEvent += HandleSearchPatientEvent;
		}

		private void HandleSearchPatientEvent(object sender, string name)
		{
			var patientName = string.IsNullOrEmpty(name) ? null : name;
			List<Patient> patients = this.patientModel.GetPatientsByName(patientName);
			foreach (var patient in patients)
				patient.IsHasProgressNote = caseHistoryModel.GetCaseHistoryByPatientId(patient.PatientId).Select(p => p.CaseType > 0).Count() > 0;
			this.View.PopulatePatientsRecords(patients);
		}
	}
}
