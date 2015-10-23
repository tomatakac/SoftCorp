using SoftCorp.Interfaces;
using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp
{
    public abstract class UserRoleDecorator : IUser
    {
        protected IUser user;

        public UserRoleDecorator(IUser newUser)
        {
            user = newUser;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public UserType UserType { get; set; }

        public Guid AgencyLicence { get; set; }

        public IList<IRole> Roles { get; set; }

        public IList<IUser> ParentAgents { get; set; }

        public IList<IUser> SubordinateAgents { get; set; }

        public CompanyFounder CompanyFounder { get; set; }

        public Guid Id { get; set; }        
    }
}
