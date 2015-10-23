using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class CSR : IUser
    {
        public CSR(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IRole> Roles { get; set; }

        public Guid Id { get; set; }
        public UserType UserType
        {
            get { return UserType.CSR; }
        }

        public Guid AgencyLicence { get; set; }

        public IList<IUser> ParentAgents { get; set; }

        public IList<IUser> SubordinateAgents { get; set; }

        public CompanyFounder CompanyFounder { get; set; } 
    }
}
