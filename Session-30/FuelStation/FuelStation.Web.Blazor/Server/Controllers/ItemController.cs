using FuelStation.EntityFramework.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase {

        private readonly IEntityRepository<Item> _itemRepository;

        public ItemController(IEntityRepository<Item> itemRepository) {
            _itemRepository = itemRepository;
        }

        // GET: <ItemsController>
        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get() {
            var result = _itemRepository.GetAll();
            return result.Select(item => new ItemListDto {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost   
            });
        }

        // GET <ItemsController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        [HttpGet("{id}")]
        public async Task<ItemEditDto> GetById(Guid id) {
            var result = _itemRepository.GetById(id);
            return new ItemEditDto {
                Id = id,
                Code = result.Code,
                Description = result.Description,
                ItemType = result.ItemType,
                Price = result.Price,
                Cost = result.Cost
            };
        }

        // POST <ItemsController>
        [HttpPost]
        public async Task Post(ItemCreateDto item) {
            var newItem = new Item(item.Description, item.ItemType, item.Price, item.Cost);
            _itemRepository.Add(newItem);
        }

        // PUT <ItemsController>/450F87A0-9FC8-4C0E-BA65-B45EEFEB9B12
        //TODO: Maybe needs id?
        [HttpPut]
        public async Task Put(ItemEditDto item) {
            var itemToUpdate = _itemRepository.GetById(item.Id);
            itemToUpdate.Code= item.Code; //this is generated, not sure if it is updated by hand
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType; 
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;            
            _itemRepository.Update(item.Id, itemToUpdate);
        }

        // DELETE <ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id) {
            _itemRepository.Delete(id);
        }
    }
}
