using MRS.Presenters.Interface;
using MRS.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenters.Presenter
{
    public class ElecCaseHistoryPresenter: Presenter<IElecCaseHistoryView>
    {
        //initilize models

        public ElecCaseHistoryPresenter(IElecCaseHistoryView view)
            : base(view)
        { 
            //init models objects
        }

        protected override void OnViewSet()
        {
            //Setup view events
        }


    }
}
