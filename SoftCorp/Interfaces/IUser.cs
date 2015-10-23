using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Interfaces
{
    public interface IUser : IIdentifier
    {
        string Name { get; set; }
        string Description { get; set; }       
        UserType UserType { get; }
        Guid AgencyLicence { get; set; }
        IList<IRole> Roles { get; set; }
        IList<IUser> ParentAgents { get; set; }
        IList<IUser> SubordinateAgents { get; set; }
        CompanyFounder CompanyFounder { get; set; }
    }
}
