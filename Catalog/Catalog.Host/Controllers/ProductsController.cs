using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly Product[] Products = new[]
        {
            new Product()
            {
                Title = "Batman: The Killing Joke",
                Description = "Bestseller",
                Price = 100,
            },
            new Product()
            {
                Title = "Scott Piligrim",
                Description = "Bestseller",
                Price = 100,
            },
            new Product()
            {
                Title = "Daytripper",
                Description = "Bestseller",
                Price = 100,
            },
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return Products;
        }
    }
}