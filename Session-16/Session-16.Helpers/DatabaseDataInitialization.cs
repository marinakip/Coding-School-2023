using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOTE: Since hard-coded random data initialization was used in a previous session (Session-10: University), this is
// the perfect opportunity to try to populate some tables of PetShopDb with AdventureWorks2019 data, since they are quite similar.
// Tables that are not identical types with AdventureWorks (Pets, PetFoods, etc) are going to be manually populated.

//TODO Step 1: Find all similar columns in tables between the two databases

//TODO: Step 2: Create resource files with the sql queries (multiple resource files)
// Queries will be:  INSERT INTO [PetShopDb].[Table] 
//                      [Column1], [Column2], [Column3], .... 
//                   SELECT TOP (5) 
//                      [Column1], [Column2], [Column3], .... 
//                   FROM [AdventureWorks2019].[Table]
//TODO: Step 3: Manually populate columns that we haven't find something similar


namespace Session_16.Helpers {
    public class DatabaseDataInitialization : IHelper {
        public DatabaseDataInitialization() { }     
       
        public virtual void TestDatabaseConnection() { }

        //TODO: Implementation
        public void InitializeDatabase() { }    

    }
}
