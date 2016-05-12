using MRS.Entity.Entities;
using MRS.Model.Interfaces;
using MRS.Model.Models;
using MRS.Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MRS.Presenter.Presenters
{
    public class CaseHistoryPresenter: ICaseHistoryPresenter
    {
        private ICaseHistoryModel caseHistoryModel;

        public CaseHistoryPresenter()
        {
            caseHistoryModel = new CaseHistoryModel();
        }
        public bool InsertCasaHistory(CaseHistory caseHistory)
        {
            return caseHistoryModel.InsertCasaHistory(caseHistory);
        }
    }
}
