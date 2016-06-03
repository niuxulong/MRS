namespace MRS.Entity.Entities
{
    public class Patient
    {
        public string PatientId { get; set; }

        public string BeinHospitalCode { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string PrithTime { get; set; }

		public bool IsHasProgressCommonNote { get; set; }

		public bool IsHasProgressTCMNote { get; set; }

		public bool HasBaseTemplateForCommonProgressNote { get; set; }

		public bool HasBaseTemplateForTCMProgressNote { get; set; }
    }
}
