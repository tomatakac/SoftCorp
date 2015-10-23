using SoftCorp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCorp.Model
{
    public class Company : ICompany
    {
        public Company(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Guid Id { get; set; }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public IList<Agent> Agents
        {
            get;
            set;
        }

        public IList<Client> Clients
        {
            get;
            set;
        }
    }
}
