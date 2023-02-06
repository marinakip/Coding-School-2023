using Session_16.Model;
using Session_16.Orm.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Business {
    public class PetShop : IBusiness {

        #region Properties
        private CustomerRepository? _customerRepository;
        private EmployeeRepository? _employeeRepository;
        private PetFoodRepository? _petFoodRepository;
        private PetRepository? _petRepository;
        private SpecialOfferRepository? _specialOfferRepository;
        private TransactionLineRepository? _transactionLineRepository;
        private TransactionRepository? _transactionRepository;
        private List<MonthlyLedger>? _monthlyLedgers;
        private List<PetReport>? _PetReports;
        //private Stock _stock;  //TODO: Add in model, configs, appdbcontext, repos, migrate and populate it (I forgot it)
        #endregion Properties

        #region Constructor
        public PetShop() { }
        #endregion Constructor

        //TODO: PETSHOP METHODS

        #region PetShop Methods
        public void AddToRepository<T>(Object obj) {
            throw new NotImplementedException();
        }

        public T CreateRepositoryObject<T>() {
            throw new NotImplementedException();
        }

        public void DeleteFromRepository<T>() {
            throw new NotImplementedException();
        }
        
        public void LoadRepositories() { }

        public void UpdateRepository<T>(Object obj) {
            throw new NotImplementedException();
        }
        #endregion PetShop Methods
    }
}
