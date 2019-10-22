using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthnicStyles.DataAccess
{
    public class Program
    {
        static void Main(string[] args)
        {

            EthnicDbEntities context = new EthnicDbEntities();
            ProductCategories pc = new ProductCategories() { ProductCatId = 1, CategoryName = "Jewelry" };
            context.ProductCategories.Add(pc);
            context.SaveChanges();

        }
    }
}
