using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Winforms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new ManagerForm();
            managerForm.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e) {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void btnCashier_Click(object sender, EventArgs e) {
            CashierForm cashierForm = new CashierForm();
            cashierForm.ShowDialog();
        }
    }
}
