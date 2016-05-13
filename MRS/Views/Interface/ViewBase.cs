using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS.Views.Interface
{
    public class ViewBase: Form
    {
        private object presenter;

        public ViewBase()
        {
            presenter = this.CreatePresenter();
        }

        protected virtual object CreatePresenter()
        {
            if (LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime)
            {
                return null;
            }
            else
            {
                throw new NotImplementedException(string.Format("{0} must override the CreatePresenter method.", this.GetType().FullName));
            }
        }
    }
}
