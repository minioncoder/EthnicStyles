using System.Collections.Generic;
using System.Data.Entity;

namespace EthnicStyles.DataAccess
{
    public class EthnicDbInitializer : CreateDatabaseIfNotExists<EthnicDbEntities>
    {
            protected override void Seed(EthnicDbEntities context)
            {
                IList<ProductCategories> pc = new List<ProductCategories>();
                pc.Add(new ProductCategories() { CategoryName = "Jewelry" });
                pc.Add(new ProductCategories() { CategoryName = "Sarees" });
                pc.Add(new ProductCategories() { CategoryName = "Dresses" });
               
                context.ProductCategories.AddRange(pc);

                base.Seed(context);
            }
        
    }
}
