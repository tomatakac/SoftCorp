using SoftCorp;
using SoftCorp.Interfaces;
using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    class Program
    {
        static void Main(string[] args)
        {
            var adminBuilder = new AdminBuilder("Eric");
            var assemble = new AssembleUser();
            assemble.Construct(adminBuilder);

            IUser adminUser = adminBuilder.User;

            UserManagement adminUserManagement = new UserManagement(adminUser);
            IUser agentUser = adminUserManagement.CreateUser(new Agent("Taylor"), true);

            adminUserManagement.CanSchedulePostsAndCampaings(agentUser);


            Console.ReadLine();
        }
    }
}
