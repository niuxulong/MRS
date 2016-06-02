using System;
using System.Collections.Generic;
using MRS.Entity.Entities;
using MRS.Presenters.Presenter;
using MRS.Views.Interface;

namespace MRS.Views.View
{
    public partial class SearchPatientView : ViewBase, ISearchPatientView
    {
        #region Event Handler
        public event EventHandler<string> SearchPatientEvent;
        public event EventHandler<Patient> SelectPatientEvent;
        #endregion

        public SearchPatientView()
        {
            InitializeComponent();
            ConfigColumns();
        }

        protected override object CreatePresenter()
        {
            return new SearchPatientPresenter(this);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var name = this.txt_Name.Text.Trim();
            name = string.IsNullOrEmpty(name) ? null : name;
            if(SearchPatientEvent != null)
            {
                SearchPatientEvent(this, name);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (this.dgv_Patient.SelectedRows.Count > 0)
            {
                var selectedPatient = this.dgv_Patient.SelectedRows[0].DataBoundItem as Patient;

                if (SelectPatientEvent != null)
                {
                    SelectPatientEvent(sender, selectedPatient);
                }
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public void PopulatePatientsRecords(List<Patient> patients)
        {
            dgv_Patient.DataSource = patients;
        }

        private void ConfigColumns()
        {
            this.dgv_Patient.AutoGenerateColumns = false;
            this.dgv_Patient.Columns["col_CaseNo"].DataPropertyName = "PatientId";
            this.dgv_Patient.Columns["col_Name"].DataPropertyName = "Name";
            this.dgv_Patient.Columns["col_HospitalNo"].DataPropertyName = "BeinHospitalCode";
            this.dgv_Patient.Columns["col_InTime"].DataPropertyName = "PrithTime";
            this.dgv_Patient.Columns["col_Sex"].DataPropertyName = "Sex";
			this.dgv_Patient.Columns["IsHasProgressNote"].DataPropertyName = "IsHasProgressNote";
        }
    }
}
