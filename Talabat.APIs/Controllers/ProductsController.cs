using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabate.Core.Entites;
using Talabate.Core.Repositories;

namespace Talabat.APIs.Controllers
{
    public class ProductsController : APIBaseController
    {
        private readonly IGenaricRepository<Product> _productRepo;

        public ProductsController(IGenaricRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }
    }
}
