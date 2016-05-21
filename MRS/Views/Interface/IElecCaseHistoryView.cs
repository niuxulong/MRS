using Common.EventArguments;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Views.Interface
{
    public interface IElecCaseHistoryView: IViewBase
    {
        event EventHandler<string> RetriveCaseHistoriesByPatientIdEvent;

        event EventHandler RetriveTemplateCatalogTree;

        event EventHandler<CaseHistory> SaveCaseHistoryEvent;

        event EventHandler<Template> SaveTemplateEvent;

        event EventHandler<Template> CreateTemplateEvent;

        event EventHandler<UpdateCaseHistoryStatusEventArgs> UpdateCasetoryStatusEvent;

        event EventHandler<UpdateCaseHistoryStatusEventArgs> DeleteCaseHistoryEvent;

        void PopulateCaseHistoryRecords(List<CaseHistory> caseHistories);

        void PopulateTemplateCatalogTree(List<TemplateCatalogNode> nodes);
    }
}
