using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_16 {
    public partial class EmployeesForm : Form {
        public EmployeesForm() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            MessageBox.Show("UNAUTHORIZED: Only Store Management has access to this action");
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            MessageBox.Show("UNAUTHORIZED: Only Store Management has access to this action");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            MessageBox.Show("UNAUTHORIZED: Only Store Management has access to this action");
        }
    }
}
