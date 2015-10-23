using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp
{
    public abstract class UserBuilder
    {
        protected IUser user;

        // Gets vehicle instance
        public IUser User
        {
            get { return user; }
        }

        // Abstract build methods
        public abstract void BuildRoles();
    }
}
