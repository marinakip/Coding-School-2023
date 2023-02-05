using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Helpers {
    public interface IHelper {
        public abstract void TestDatabaseConnection();
        public abstract void InitializeDatabase();
    }
}
