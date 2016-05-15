using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;

namespace MRS.Presenters.Presenter
{
    public class ElecCaseHistoryPresenter: Presenter<IElecCaseHistoryView>
    {
        public ICaseHistoryModel caseHistoryModel { get; private set; }

        public ITemplateCatalogModel templateCatalogModel { get; private set; }

        public ElecCaseHistoryPresenter(IElecCaseHistoryView view)
            : base(view)
        {
            caseHistoryModel = new CaseHistoryModel();
            templateCatalogModel = new TemplateCatalogModel();
        }

        protected override void OnViewSet()
        {
            this.View.RetriveCaseHistoriesByPatientIdEvent += HandleRetriveCaseHistoriesByPatientIdEvent;
            this.View.RetriveTemplateCatalogTree += HandleRetriveTemplateCatalogTree;
            this.View.SaveCaseHistoryEvent += HandleSaveCaseHistoryEvent;
        }

        private void HandleSaveCaseHistoryEvent(object sender, CaseHistory caseHistory)
        {
            caseHistoryModel.InsertCaseHistory(caseHistory);
            HandleRetriveCaseHistoriesByPatientIdEvent(sender, caseHistory.PatientId);
        }

        private void HandleRetriveTemplateCatalogTree(object sender, object e)
        {
            var templateTreeNodes = templateCatalogModel.GetTemplateCatalogNodes();
            if (templateTreeNodes != null)
            {
                this.View.PopulateTemplateCatalogTree(templateTreeNodes);
            }
        }

        private void HandleRetriveCaseHistoriesByPatientIdEvent(object sender, string patientId)
        {
            if (!string.IsNullOrEmpty(patientId))
            {
                var caseHistories = caseHistoryModel.GetCaseHistoryByPatientId(patientId);
                this.View.PopulateCaseHistoryRecords(caseHistories);
            }
            
        }
    }
}
