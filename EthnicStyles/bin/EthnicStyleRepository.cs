using EthnicStyles.DataAccess.EthnicInterfaces;
using EthnicStyles.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EthnicStyles.DataAccess
{
    public class EthnicStyleRepository : IEthnicStyleRepository
    {
        public EthnicDbEntities _et;

        public EthnicStyleRepository(EthnicDbEntities et)
        {
            this._et = et;
        }

        public void AddProducts(ProductMinInfo product)
        {
            Products p1 = new Products();
            p1.Description = product.Description;
            p1.ItemName = product.ItemName;
            p1.Price = product.Price;
            _et.Products.Add(p1);
            _et.SaveChanges();
        }
        public List<ProductMinInfo> GetProducts()
        {
            var prods = _et.Products.Select( p => new ProductMinInfo()
            {
             ItemName = p.ItemName,
             Price = p.Price,
             Description = p.Description
            })
            .ToList();
            return prods;
        }

        public List<ProductCategories> GetProductCategories()
        {
            return _et.ProductCategories.ToList();
        }

        public List<User> GetUsers()
        {
            return _et.User.ToList();
        }

        public List<UserRoles> GetUserRoles()
        {
            return _et.UserRoles.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _et.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
