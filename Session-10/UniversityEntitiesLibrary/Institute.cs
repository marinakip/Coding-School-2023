using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Institute {
        #region Properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }
        #endregion Properties

        #region Constructors
        public Institute() { }

        public Institute(Guid id) {
            ID = id;
        }
        public Institute(Guid id, string name) {
            ID = id;
            Name = name;
        }
        public Institute(Guid id, string name, int yearsInService) {
            ID = id;
            Name = name;
            YearsInService = yearsInService;
        }
        #endregion Constructors

        #region Methods
        public void GetName() { }

        public void SetName(string name) { }
        #endregion Methods
    }
}
