using Common.EventArguments;
using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System.Linq;

namespace MRS.Presenters.Presenter
{
    public class ElecCaseHistoryPresenter: Presenter<IElecCaseHistoryView>
    {
        public ICaseHistoryModel caseHistoryModel { get; private set; }

        public ITemplateCatalogModel templateCatalogModel { get; private set; }

        public ITemplateModel templateModel { get; private set; }

        public IPatientModel patientModel { get; private set; }


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
            this.View.CreateTemplateEvent += View_CreateTemplateEvent;
            this.View.UpdateCasetoryStatusEvent += HandleUpdateCasetoryStatusEvent;
            this.View.DeleteCaseHistoryEvent += HandleDeleteCaseHistoryEvent;
        }

        void View_CreateTemplateEvent(object sender, Template template)
        {
            templateModel.InsertTemplate(template);
        }

        private void HandleDeleteCaseHistoryEvent(object sender, UpdateCaseHistoryStatusEventArgs args)
        {
            caseHistoryModel.DeleteCaseHistory(args.caseHistoryId);
            HandleRetriveCaseHistoriesByPatientIdEvent(sender, args.PatientId);
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
            var currentId = caseHistory.Id;

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
                View.CurrentPatient.IsHasProgressNote = caseHistories.Select(p => p.CaseType > 0).Count() > 0;
                this.View.PopulateCaseHistoryRecords(caseHistories);
            }
            
        }
    }
}
