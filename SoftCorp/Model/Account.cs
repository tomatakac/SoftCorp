using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class Account
    {
        public String Name { get; set; }
        public List<IUser> Users { get; set; }
        public Company Company {get; set;}
    }
}
