using Common.EventArguments;
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

        public ITemplateModel templateModel { get; private set; }

        public ElecCaseHistoryPresenter(IElecCaseHistoryView view)
            : base(view)
        {
            caseHistoryModel = new CaseHistoryModel();
            templateCatalogModel = new TemplateCatalogModel();
            templateModel = new TemplateModel();
        }

        protected override void OnViewSet()
        {
            this.View.RetriveCaseHistoriesByPatientIdEvent += HandleRetriveCaseHistoriesByPatientIdEvent;
            this.View.RetriveTemplateCatalogTree += HandleRetriveTemplateCatalogTree;
            this.View.SaveCaseHistoryEvent += HandleSaveCaseHistoryEvent;
            this.View.SaveTemplateEvent += HandleSaveTemplateEvent;
            this.View.UpdateCasetoryStatusEvent += HandleUpdateCasetoryStatusEvent;
        }

        private void HandleUpdateCasetoryStatusEvent(object sender, UpdateCaseHistoryStatusEventArgs args)
        {
            caseHistoryModel.UpdateCaseHistoryStatus(args.caseHistoryId, args.status);
            HandleRetriveCaseHistoriesByPatientIdEvent(sender, args.PatientId);
        }

        private void HandleSaveTemplateEvent(object sender, Template template)
        { 
            templateModel.UpdateTemplate(template);
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
