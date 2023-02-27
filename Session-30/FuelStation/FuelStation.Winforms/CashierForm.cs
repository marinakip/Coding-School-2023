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
    public partial class CashierForm : Form {
        public CashierForm() {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            TransactionsForm transactionsForm = new TransactionsForm();
            transactionsForm.ShowDialog();
        }
    }
}
