using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {
    public partial class FrmFinalReport : Form {
        public FrmFinalReport() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private List<StudentReportView> GenerateStudentReport() 
        {
            var allStudents = StudentRepository.GetStudents();
            var examReports = new List<StudentReportView>();

            foreach (var student in allStudents) {
                if (student.HasSignature()) {
                    var examReport = new StudentReportView(student);
                    examReports.Add(examReport);
                }
            }
            return examReports;

        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void FrmFinalReport_Load(object sender, EventArgs e) {
            var results = GenerateStudentReport();
            dgvResults.DataSource = results; 
        }
    }
}
