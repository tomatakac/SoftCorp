using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class DashBoardManagementRole : IRole
    {
        public Guid Id { get; set; }
        public DashBoardManagementRole()
        {
            Name = "DashBoardManagement";
            Description = "See all financial and statistical dash boards";
        }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
