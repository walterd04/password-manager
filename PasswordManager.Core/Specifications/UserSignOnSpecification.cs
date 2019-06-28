using PasswordManager.Core.Entities;
using PasswordManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Specifications
{
    public sealed class UserSignOnSpecificationUser : BaseSpecification<Users>
    {
        public UserSignOnSpecificationUser(string username) : base(user => user.Username == username)
        {
            
        }
    }

    public sealed class UserSignOnSpecificationUserPass : BaseSpecification<Users>
    {
        public UserSignOnSpecificationUserPass(string username, string password) : base(user => user.Username == username && user.Password == password)
        {
            AddInclude(o => o.Username == username && o.Password == password);
        }
    }

    public sealed class UserSignOnSpecificationEmailPass : BaseSpecification<Users>
    {
        public UserSignOnSpecificationEmailPass(string email, string password) : base(user => user.Email == email && user.Password == password)
        {
            AddInclude(o => o.Email == email && o.Password == password);
        }
    }
}
