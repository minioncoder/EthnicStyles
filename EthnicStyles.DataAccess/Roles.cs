﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EthnicStyles.DataAccess
{
    public class Roles
    {
        public Roles()
        {

        }

        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
