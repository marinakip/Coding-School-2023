using System.Data;
using Microsoft.Data.SqlClient;
using Session_16.Helpers;
using Session_16.Orm.Repositories;

namespace Session_16 {
    //NOTE: Couldn't manage to open again DevExpress Toolbox, Visual Studio was constantly crashing when tried to repair toolbox, so basic WinForms were used
    public partial class Form1 : Form {       
       
        public Form1() {
            InitializeComponent();
        }

        private void btnTestDatabase_Click(object sender, EventArgs e) {
            IHelper databaseConnection = new DatabaseConnection();
            try {
                databaseConnection.TestDatabaseConnection();
              MessageBox.Show("Connected Successfully to PetShop Database");
            } catch (Exception) {
                throw new Exception("Error connecting to PetShop Database");
            }           
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Repositories are going to be loaded seperately in their own form
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            CustomersForm customers = new CustomersForm();
            customers.ShowDialog();

        }

        private void btnEmployees_Click(object sender, EventArgs e) {
            EmployeesForm employees = new EmployeesForm();
            employees.ShowDialog(); 
        }

        private void btnOrders_Click(object sender, EventArgs e) {
            TransactionsForm transactions = new TransactionsForm();
            transactions.ShowDialog();  
        }

        private void btnStoreManagement_Click(object sender, EventArgs e) {
            StoreManagementForm storeManagement = new StoreManagementForm();
            storeManagement.ShowDialog();   
            
        }
    }
}