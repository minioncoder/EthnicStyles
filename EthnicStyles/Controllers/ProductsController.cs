using EthnicStyles.DataAccess;
using EthnicStyles.DataAccess.EthnicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EthnicStyles.Controllers

{   
    public class ProductsController : ApiController
    {
        IEthnicStyleRepository _ethnicStyleRepository;

        ProductCategories[] products = new ProductCategories[]{
         new ProductCategories { ProductCatId = 1, CategoryName = "Jewelry" },
          new ProductCategories { ProductCatId = 2, CategoryName = "Sarees" },
           new ProductCategories { ProductCatId = 3, CategoryName = "Dresses" }
        };

        public ProductsController()
        {

        }
        public ProductsController(IEthnicStyleRepository ethnicStyleRepository)
        {
            _ethnicStyleRepository = ethnicStyleRepository;
        }


        [Route("api/products")]
        [HttpGet]
        public IEnumerable<Products> GetAllProducts()
        {
            return _ethnicStyleRepository.GetProducts();
        }

        [HttpGet]
        [Route("api/productCategories")]
        public IEnumerable<ProductCategories> GetAllProductCategories()
        {
            return _ethnicStyleRepository.GetProductCategories();
        }

    }
}
