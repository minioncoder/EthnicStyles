using EthnicStyles.DataAccess;
using EthnicStyles.DataAccess.EthnicInterfaces;
using EthnicStyles.DataAccess.Models;
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
        

        public ProductsController(IEthnicStyleRepository ethnicStyleRepository)
        {
            _ethnicStyleRepository = ethnicStyleRepository;
        }


        [Route("api/products")]
        [HttpGet]
        public List<ProductMinInfo> GetAllProducts()
        {
            return _ethnicStyleRepository.GetProducts();
        }

        [HttpGet]
        [Route("api/productCategories")]
        public List<ProductCategories> GetAllProductCategories()
        {
            return _ethnicStyleRepository.GetProductCategories();
        }

        [HttpPost]
        [Route("api/products/{id}")]
        public void AddProducts(ProductMinInfo p)
        {
            _ethnicStyleRepository.AddProducts(p);
        }

    }
}
