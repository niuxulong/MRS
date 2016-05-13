using MRS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Views.Interface
{
    public interface ISearchPatientView: IViewBase
    {
        event EventHandler<string> SearchPatientEvent;

        void PopulatePatientsRecords(List<Patient> patients);
    }
}
