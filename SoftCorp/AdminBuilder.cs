using SoftCorp.Interfaces;
using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp
{
    //I just created an AdminBuilder for example, same is for the CSR which has also predefined roles  
    public class AdminBuilder : UserBuilder
    {
        public AdminBuilder(String agentName)
        {
            user = new Admin(agentName);
        }
        public override void BuildRoles()
        {
            if(user.Roles == null)
            {
                user.Roles = new List<IRole>();
            }
            user.Roles.Add(new AccountManagementRole());
            user.Roles.Add(new TicketManagementRole());
            user.Roles.Add(new DashBoardManagementRole());
            user.Roles.Add(new TicketsAndEscrowDisputesRole());
        }       
    }
}
