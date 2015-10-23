using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class TicketManagementRole : IRole
    {
        public Guid Id { get; set; }
        public TicketManagementRole()
        {
            Name = "AllTicketManagement";
            Description = "Can manage all tickets";
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
