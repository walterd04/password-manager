using PasswordManager.Core.Entities;
using PasswordManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _repository;

        public UsersService(IUserRepository repository)
        {
            this._repository = repository;
        }

        public Users SignUp(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Users GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IReadOnlyList<Users> GetAll()
        {
            return _repository.GetAll();
        }

        public IReadOnlyList<Users> GetAll(ISpecification<Users> specification)
        {
            return _repository.GetAll(specification);
        }

        public Users Add(Users entity)
        {
            return _repository.Add(entity);
        }

        public void Update(Users entity)
        {
            _repository.Update(entity);
        }

        public void Delete(Users entity)
        {
            _repository.Delete(entity);
        }
    }
}
