using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenter.Interfaces
{
    public interface ITemplatePresenter
    {
        List<Template> GetTemplates();
    }
}
