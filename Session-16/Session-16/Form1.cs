using System.Data;
using Microsoft.Data.SqlClient;

namespace Session_16 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnTestDatabase_Click(object sender, EventArgs e) {
            SqlConnection  connection = new SqlConnection();
            //connection.ConnectionString = "data source=MARINA-KIPOUROU; initial catalog=AdventureWorksLT2019; integrated security=SSPI; TrustServerCertificate=True;";
            connection.ConnectionString = "data source=MARINA-KIPOUROU; initial catalog=AdventureWorks2019; integrated security=SSPI; TrustServerCertificate=True;"; 
            connection.Open();

            DataSet ds = new DataSet(); 
            

            string selectQuery = Resource1.CustomerQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);

            adapter.Fill(ds);
            ds.WriteXml("marina.xml");
        }
    }
}