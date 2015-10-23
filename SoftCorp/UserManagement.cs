using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;
using SoftCorp.Interfaces;
using SoftCorp.Model;

namespace SoftCorp
{
    public class UserManagement : UserRoleDecorator
    {
        public UserManagement(IUser user): base(user)
        {            
        }

        public IUser CreateUser(IUser newUser, bool isSubordinate)
        {
            if (!_users.Contains(newUser))
            {
                _users.Add(newUser);
            }
            if (isSubordinate)
            {
                if(user.SubordinateAgents == null)
                    user.SubordinateAgents = new List<IUser>();
                if (newUser.ParentAgents == null)
                    newUser.ParentAgents = new List<IUser>();
                user.SubordinateAgents.Add(newUser);
                newUser.ParentAgents.Add(user);
            }
            return newUser;
        }

        public void RemoveUser(IUser user)
        {
            if (_users.Contains(user))
            {
                _users.Remove(user);
            }
        }

        public void AddPermission(IUser user, IRole role)
        {
            user.Roles.Add(role);
        }

        public void RemovePermission(IUser user, IRole role)
        {
            user.Roles.Remove(role);
        }
        public void CreateCompany(Company company)
        {
            user.CompanyFounder = new CompanyFounder { User = user, Company = company};
            if (!_companies.Contains(company))
            {
                _companies.Add(company);
            }
        }

        public void RemoveCompany(Company company)
        {
            if (_companies.Contains(company))
            {
                _companies.Remove(company);
            }
        }

        public void CreateAccount(Account newAccount)
        {
            if (!_accounts.Contains(newAccount))
            {
                _accounts.Add(newAccount);
            }
        }

        public void RemoveAccount(Account accountToRemove)
        {
            if (_accounts.Contains(accountToRemove))
            {
                _accounts.Remove(accountToRemove);
            }
        }

        public void CreateClient(Client client)
        {
            if (!_clients.Contains(client))
            {
                _clients.Add(client);
            }
        }

        public void RemoveClient(Client client)
        {
            if (_clients.Contains(client))
            {
                _clients.Remove(client);
            }
        }

        public bool CanSchedulePostsAndCampaings(IUser IUser)
        {
            if (IUser.Roles != null && IUser.Roles.Any(r => r.Name == "TicketsAndEscrowDisputesHandling"))
            {
                return true;
            }
            foreach (var custom in IUser.ParentAgents)
            {
                if (custom.Roles.Any(r => r.Name == "TicketsAndEscrowDisputesHandling"))
                    return true;
            }
            return false;
        }

        protected readonly List<Client> _clients = new List<Client>();
        protected readonly List<IUser> _users = new List<IUser>();
        protected readonly List<Account> _accounts = new List<Account>();
        protected readonly List<Company> _companies = new List<Company>();
    }
}
