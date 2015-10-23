using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class CompanyFounder
    {
        public ICompany Company { get; set; }
        public IUser User { get; set; }
    }
}
