using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthnicStyles.DataAccess.EthnicInterfaces
{
    public interface IEthnicStyleRepository
    {
        //void Add(Products products);
        //void Remove(Products product);
        List<Products> GetProducts();
        List<ProductCategories> GetProductCategories();
    }
}
