using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Entity.Entities
{
    public class Patient
    {
        public string PatientId { get; set; }

        public string BeinHospitalCode { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string PrithTime { get; set; }
    }
}
