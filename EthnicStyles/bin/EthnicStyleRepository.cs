using EthnicStyles.DataAccess.EthnicInterfaces;
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
        public List<Products> GetProducts()
        {
            var prods = _et.Products.ToList();
            return prods;
        }

        public List<ProductCategories> GetProductCategories()
        {
            return _et.ProductCategories.ToList();
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
