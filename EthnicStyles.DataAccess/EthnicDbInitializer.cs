using System.Collections.Generic;
using System.Data.Entity;

namespace EthnicStyles.DataAccess
{
    public class EthnicDbInitializer : DropCreateDatabaseAlways<EthnicDbEntities>
    {
            protected override void Seed(EthnicDbEntities context)
            {
                IList<ProductCategories> pc = new List<ProductCategories>();
                pc.Add(new ProductCategories() { CategoryName = "Jewelry" });
                pc.Add(new ProductCategories() { CategoryName = "Sarees" });
                pc.Add(new ProductCategories() { CategoryName = "Dresses" });
                //IList<Products> products = new List<Products>();

                //products.Add(new Standard() { StandardName = "Standard 1", Description = "First Standard" });
                //products.Add(new Standard() { StandardName = "Standard 2", Description = "Second Standard" });
                //products.Add(new Standard() { StandardName = "Standard 3", Description = "Third Standard" });

                context.ProductCategories.AddRange(pc);

                base.Seed(context);
            }
        
    }
}
