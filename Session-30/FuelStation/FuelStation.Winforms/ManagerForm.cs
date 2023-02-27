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
    public partial class ManagerForm : Form {
        public ManagerForm() {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            CustomersForm customersForm = new CustomersForm();  
            customersForm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e) {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog(); 
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            TransactionsForm transactionsForm = new TransactionsForm(); 
            transactionsForm.ShowDialog();
        }
    }
}
