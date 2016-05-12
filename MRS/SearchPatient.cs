using MRS.Entity.Entities;
using MRS.Presenter.Interfaces;
using MRS.Presenter.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS
{
    public delegate void SelectPatientEventHandler(Patient patient);

    public partial class SearchPatient : Form
    {
        private IPatientPresenter patientPresenter = new PatientPresenter();

        public event SelectPatientEventHandler SelectPatientEvent;

        public SearchPatient()
        {
            InitializeComponent();
            ConfigColumns();
        }

        private void ConfigColumns()
        {
            this.dgv_Patient.Columns["col_CaseNo"].DataPropertyName = "PatientId";
            this.dgv_Patient.Columns["col_Name"].DataPropertyName = "Name";
            this.dgv_Patient.Columns["col_HospitalNo"].DataPropertyName = "BeinHospitalCode";
            this.dgv_Patient.Columns["col_InTime"].DataPropertyName = "PrithTime";
            this.dgv_Patient.Columns["col_Sex"].DataPropertyName = "Sex";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var name = this.txt_Name.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                var patient = patientPresenter.GetPatientsByName(name);
                this.dgv_Patient.DataSource = patient;
            }
        }

        private void ShowPatient(List<Patient> patients)
        {
            foreach (var patient in patients)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dgv_Patient);
                dr.Cells["col_CaseNo"].Value = patient.PatientId;
                dr.Cells["col_Name"].Value = patient.Name;
                dr.Cells["col_HospitalNo"].Value = patient.BeinHospitalCode;
                dr.Cells["col_InTime"].Value = patient.PrithTime;
                dgv_Patient.Rows.Add(dr);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (SelectPatientEvent != null && this.dgv_Patient.SelectedRows.Count > 0)
                SelectPatientEvent((Patient)this.dgv_Patient.SelectedRows[0].DataBoundItem);

            this.Close();
        }
    }
}
