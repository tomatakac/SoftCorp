using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class AccountManagementRole : IRole
    {
        public Guid Id { get; set; }
        public AccountManagementRole()
        {
            Name = "AllAccountManagement";
            Description = "Can manage all accounts";
        }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
