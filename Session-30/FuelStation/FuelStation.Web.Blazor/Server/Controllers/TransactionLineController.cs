using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using FuelStation.Web.Blazor.Shared.TransactionDataTranferObjects;
using FuelStation.Web.Blazor.Shared.TransactionLineDataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {

        private readonly IEntityRepository<Transaction> _transactionRepository;
        private readonly IEntityRepository<Item> _itemRepository;
        private readonly IEntityRepository<TransactionLine> _transactionLineRepository;

        public TransactionLineController(IEntityRepository<Transaction> transactionRepository, 
            IEntityRepository<Item> itemRepository, IEntityRepository<TransactionLine> transactionLineRepository) {
            
            _transactionRepository = transactionRepository;
            _itemRepository = itemRepository;
            _transactionLineRepository = transactionLineRepository;
        }


        // GET: <TransactionLineController>
        [HttpGet]
        public IEnumerable<TransactionLineListDto> Get() {
            var result = _transactionLineRepository.GetAll();
            return result.Select(transactionLine => new TransactionLineListDto {
                Id = transactionLine.Id,
                TotalValue = transactionLine.TotalValue,
                Quantity = transactionLine.Quantity,
                ItemPrice = transactionLine.ItemPrice,
                NetValue = transactionLine.NetValue,
                DiscountPercent = transactionLine.DiscountPercent,
                DiscountValue = transactionLine.DiscountValue,
                TransactionId = transactionLine.TransactionId,
                ItemId = transactionLine.ItemId,
            });
        }

        // GET <TransactionLineController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpGet("{id}")]
        public TransactionLineEditDto GetById(Guid id) {
            var result = _transactionLineRepository.GetById(id);
            var transactions = _transactionRepository.GetAll();
            var items = _itemRepository.GetAll();
            return new TransactionLineEditDto {
                Id = id,
                Quantity = result.Quantity,
                ItemPrice= result.ItemPrice,    
                NetValue = result.NetValue,
                DiscountPercent = result.DiscountPercent,
                DiscountValue = result.DiscountValue,   
                TotalValue= result.TotalValue,  
                TransactionId= result.TransactionId,
                ItemId = result.ItemId,  
                ItemCode = result.Item.Code,
                ItemDescription = result.Item.Description,

                Transactions = transactions.Select(transaction => new TransactionListDto {
                    Id = transaction.Id
                }).ToList(),

                Items = items.Select(item => new ItemListDto {
                    Id = item.Id,
                    Code = item.Code,
                    Description = item.Description
                }).ToList()
            };
        }

        // POST <TransactionLineController>
        [HttpPost]
        public async Task Post(TransactionLineCreateDto transactionLine) {
            var newTransactionLine = new TransactionLine(transactionLine.TransactionId, transactionLine.ItemId, transactionLine.Quantity, transactionLine.ItemPrice, transactionLine.DiscountPercent);
            _transactionLineRepository.Add(newTransactionLine);
        }

        // PUT <TransactionLineController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12        
        [HttpPut]
        public async Task Put(TransactionLineEditDto transactionLine) {
            var transactionLineToUpdate = _transactionLineRepository.GetById(transactionLine.Id);

            transactionLineToUpdate.Quantity = transactionLineToUpdate.Quantity;
            transactionLineToUpdate.ItemPrice = transactionLineToUpdate.ItemPrice;
            transactionLineToUpdate.NetValue = transactionLineToUpdate.NetValue;
            transactionLineToUpdate.DiscountPercent = transactionLineToUpdate.DiscountPercent;
            transactionLineToUpdate.DiscountValue = transactionLineToUpdate.DiscountValue;
            transactionLineToUpdate.TotalValue = transactionLineToUpdate.TotalValue;
            transactionLineToUpdate.TransactionId = transactionLineToUpdate.TransactionId;
            transactionLineToUpdate.ItemId = transactionLineToUpdate.ItemId;
            _transactionLineRepository.Update(transactionLine.Id, transactionLineToUpdate);
        }

        // DELETE <TransactionLineController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpDelete("{id}")]
        public void Delete(Guid id) {
            _transactionLineRepository.Delete(id);
        }
    }
}
