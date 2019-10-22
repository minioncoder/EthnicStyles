using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EthnicStyles.DataAccess
{
    public class UserRoles
    {
        [Key]
        public int UserRoleId { get; set; }
        public User UserId { get; set; }
        public Roles RoleId { get; set; }
    }
}
