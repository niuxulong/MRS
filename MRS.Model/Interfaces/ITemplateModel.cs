using Common.Enums;
using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Interfaces
{
    public interface ITemplateModel
    {
        List<Template> GetTemplatesByFilter(string name, int parentNodeId, Enums.TemplateAttrEnum templateAttr);

        bool UpdateTemplate(Template template);

        bool RemoveTemplates(Template template);

        bool InsertTemplate(Template template);
    }
}
