using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    class TicketsAndEscrowDisputesRole : IRole
    {
        public Guid Id { get; set; }
        public TicketsAndEscrowDisputesRole()
        {
            Name = "TicketsAndEscrowDisputesHandling";
            Description = "Can handle tickets and escrow/transaction disputes";
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
