using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EthnicStyles.DataAccess
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public long ProductCategoryId { get; set; }
        public string Description { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public ProductCategories ProdCategoryId { get; set; }
    }
}
