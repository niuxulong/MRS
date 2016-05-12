using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Presenter.Interfaces
{
    public interface ITemplateCatalogPresenter
    {
        List<TemplateCatalogNode> GetTemplateCatalogNodes();

        bool UpdateOrAddTemplateCatgalogNodes(List<TemplateCatalogNode> nodes);
    }
}
