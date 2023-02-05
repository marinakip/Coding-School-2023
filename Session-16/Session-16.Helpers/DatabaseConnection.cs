using System;
using Microsoft.Data.SqlClient;

namespace Session_16.Helpers {
    public class DatabaseConnection {
        public DatabaseConnection() { }

        public void TestDatabaseConnection() {
            string connectionString = "data source=MARINA-KIPOUROU; initial catalog=PetShopDb; integrated security=SSPI; TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);            
            connection.Open();               
        }        
    }
}
