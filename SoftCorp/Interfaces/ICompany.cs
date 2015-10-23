using SoftCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Interfaces
{
    public interface ICompany : IIdentifier
    {
        string Name { get; set; }
        string Description { get; set; }
        IList<Agent> Agents { get; set; }
        IList<Client> Clients { get; set; }
    }
}
