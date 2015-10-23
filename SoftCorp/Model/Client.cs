using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class Client : IUser
    {
        public Client(string name, IList<IRole> roles)
        {
            Name = name;
            Roles = roles;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IRole> Roles { get; set; }

        public UserType UserType
        {
            get { return UserType.Client; }
        }

        public Guid AgencyLicence { get; set; }

        ICompany Companie { get; set; }


        public IList<IUser> ParentAgents { get; set; }

        public IList<IUser> SubordinateAgents { get; set; }

        public CompanyFounder CompanyFounder { get; set; }        
    }
}
