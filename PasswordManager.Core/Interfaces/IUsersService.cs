using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Interfaces
{
    public interface IUsersService 
    {
        Entities.Users SignUp(Entities.Users entity);
        Entities.Users SignIn(string username, string password);
        Entities.Users GetById(int id);
        IReadOnlyList<Entities.Users> GetAll();
        IReadOnlyList<Entities.Users> GetAll(ISpecification<Entities.Users> specification);
        Entities.Users Add(Entities.Users entity);
        void Update(Entities.Users entity);
        void Delete(Entities.Users delete);
    }
}
