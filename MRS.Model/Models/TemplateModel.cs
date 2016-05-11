using Common.DataBaseAccessor;
using MRS.Entity.Entities;
using MRS.Model.Const;
using MRS.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Model.Models
{
    public class TemplateModel: ITemplateModel
    {
        public TemplateModel()
        { 
        
        }

        public List<Template> GetTemplates()
        {
            try
            {
                var results = new List<Template>();
                var dataSet = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), SqlConst.SP_SELECTTEMPLATE);
                //dataSet.Tables
                return ConvertToTemplatesList(dataSet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private List<Template> ConvertToTemplatesList(DataSet dataSet)
        {
            List<Template> results = new List<Template>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var template = new Template();
                template.RecordId = dataRow.ItemArray[0].ToString();
                template.FileName = dataRow.ItemArray[1].ToString();
                template.FileTitle = dataRow.ItemArray[2].ToString();
                template.FileContent = dataRow.ItemArray[3].ToString();

                results.Add(template);
            }

            return results;
        }
    }
}
