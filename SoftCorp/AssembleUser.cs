using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp
{
    public class AssembleUser
    {
        public void Construct(UserBuilder builder)
        {
            builder.BuildRoles();
        }
    }
}
