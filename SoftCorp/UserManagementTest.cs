using NUnit.Framework;
using SoftCorp.Interfaces;
using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp
{
    [TestFixture]
    public class UserManagementTest
    {
        [Test]
        public void TestUser()
        {
            var adminBuilder = new AdminBuilder("Eric");
            var assemble = new AssembleUser();
            assemble.Construct(adminBuilder);

            IUser adminUser = adminBuilder.User;
            adminUser.Description = "didkasdlkajsldj";
            adminUser.AgencyLicence = Guid.NewGuid();
            adminUser.CompanyFounder = new CompanyFounder
            {
                User = adminUser,
                Company = new Company("SoftCorp", "asdasdasdasd")
            };

            UserManagement adminUserManagement = new UserManagement(adminUser);

            IUser agentUser = new Agent("Taylor");
            agentUser.Description = "asdasdasdasdasd";
            agentUser = adminUserManagement.CreateUser(agentUser, true);

            adminUserManagement.CanSchedulePostsAndCampaings(agentUser);

            Assert.IsTrue(adminUserManagement.CanSchedulePostsAndCampaings(agentUser));
        }
    }
}
