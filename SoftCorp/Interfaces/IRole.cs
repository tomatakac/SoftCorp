using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Interfaces
{
    public interface IRole : IIdentifier
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
