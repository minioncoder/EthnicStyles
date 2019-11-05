using EthnicStyles.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthnicStyles.DataAccess.EthnicInterfaces
{
    public interface IEthnicStyleRepository
    {
        void AddProducts(ProductMinInfo products);
       // void Remove(Products product);
        List<User> GetUsers();
        List<UserRoles> GetUserRoles();
        List<ProductMinInfo> GetProducts();
        List<ProductCategories> GetProductCategories();
    }
}
