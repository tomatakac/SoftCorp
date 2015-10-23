using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class Admin : IUser
    {
        public Admin(string name)
        {
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public IList<IRole> Roles { get; set; }        

        public UserType UserType
        {
            get { return UserType.Admin; }
        }

        public Guid AgencyLicence { get; set; }
        
        private readonly IList<IRole> _roles = new List<IRole>(){new AccountManagementRole(), 
                                                                 new TicketManagementRole(), 
                                                                 new DashBoardManagementRole(), 
                                                                 new TicketsAndEscrowDisputesRole() };

        public IList<IUser> ParentAgents { get; set; }

        public IList<IUser> SubordinateAgents { get; set; }

        public CompanyFounder CompanyFounder { get; set; }
    }
}
