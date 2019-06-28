
using PasswordManager.Core.Entities;
using PasswordManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Infrastructure
{
    public class UsersRepository : Repository<Users>, IUserRepository
    {
        public UsersRepository(IRepositoryAsync<Users> repository) : base(repository)
        {

        }
    }
}
