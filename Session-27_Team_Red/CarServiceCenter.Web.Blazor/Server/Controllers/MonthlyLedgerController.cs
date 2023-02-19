using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared;
using CarServiceCenter.Web.Blazor.Shared.MonthlyLedger;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        
        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo,
                                        IEntityRepo<Manager> managerRepo,
                                        IEntityRepo<Engineer> engineerRepo)
        {
            _transactionRepo = transactionRepo;
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
        }

        [HttpGet]     
        public async Task<IEnumerable<MonthlyLedgerDto>> Get() {
            List<MonthlyLedgerDto> monthlyLedgers = new(); 
            //var monthlyLedgers = new IList<MonthlyLedgerDto>();
            var transactions = _transactionRepo.GetAll().ToList();
            var managers = _managerRepo.GetAll().ToList();
            var engineers = _engineerRepo.GetAll().ToList();

           
            decimal totalTransactions = 0;
            decimal totalSalaryEngineers = 0;
            decimal totalSalaryManagers = 0;
            foreach ( var transaction in transactions )
            {
                totalTransactions += transaction.TotalPrice;
            }
            foreach(var manager in managers)
            {
                totalSalaryManagers += manager.SalaryPerMonth;
                //totalSalaryManagers += managers.Select(manager => manager.SalaryPerMonth).SingleOrDefault();
            }
            foreach(var engineer in engineers)
            {
                totalSalaryEngineers += engineer.SalaryPerMonth;
                //totalSalaryEngineers += engineers.Select(engineer => engineer.SalaryPerMonth).SingleOrDefault();
            }

            //MonthlyLedgerDto monthlyLedger = new MonthlyLedgerDto();
            var groupedTransactions = transactions.GroupBy(transactions => new { transactions.Date.Year, transactions.Date.Month})
                .Select(grouped => new MonthlyLedgerDto {
                    Year = grouped.Key.Year,
                    Month = grouped.Key.Month,
                    //Income = grouped.Sum(transactions => transactions.totalTransactions),
                    Income = totalTransactions,
                    Expenses =  totalSalaryManagers + totalSalaryEngineers,
                    Total = totalTransactions - (totalSalaryEngineers + totalSalaryManagers)
                });

            foreach (var grouped in groupedTransactions) {
                monthlyLedgers.Add(grouped);
            }
            //monthlyLedgers.Add(monthlyLedger);
            return groupedTransactions;
            //return monthlyLedgers;
        }   
    }
}
