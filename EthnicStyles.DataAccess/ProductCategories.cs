using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EthnicStyles.DataAccess
{
    public class ProductCategories
    {
        [Key]
        public int ProductCatId { get; set; }
        public string CategoryName { get; set; }
    }
}
