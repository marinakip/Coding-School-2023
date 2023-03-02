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
    public partial class CreateTransactionForm : Form {
        public CreateTransactionForm() {
            InitializeComponent();
        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxEmployeeSurname_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxEmployeeName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBoxTotalValue_TextChanged(object sender, EventArgs e) {
            //maybe total value is not needed in this form, so probabaly remove it from Dto too
        }

        private void btnOK_Click(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
