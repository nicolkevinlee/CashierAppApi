using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashierAppApi.Controllers
{
    [Route("CashierAppApi/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetItems")]
        public IEnumerable<Item> Get()
        {   
            //to replace with database.
            return new List<Item>()
            {
                new Item(1,"Item 1",100m),
                new Item(2,"Item 2",150.5m),
                new Item(3,"Item 3",201m),
                new Item(4,"Item 4",251.5m),
                new Item(5,"Item 5",302m),
                new Item(6,"Item 6",352.5m),
                new Item(7,"Item 7",403m),
                new Item(8,"Item 8",453.5m),
                new Item(9,"Item 9",504m),
                new Item(10,"Item 10",554.5m),
                new Item(11,"Item 11",605m),
                new Item(12,"Item 12",655.5m),
                new Item(13,"Item 13",706m),
                new Item(14,"Item 14",756.5m),
                new Item(15,"Item 15",807m),
                new Item(16,"Item 16",857.5m),
                new Item(17,"Item 17",908m),
                new Item(18,"Item 18",958.5m),
                new Item(19,"Item 19",1009m),
                new Item(20,"Item 20",1059.5m)
            };
        }
    }
}
