using Microsoft.AspNetCore.Identity;
using PasswordEncryptor.Interfaces;
using PasswordManager.Core.Entities;
using PasswordManager.Core.Interfaces;
using PasswordManager.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Core.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _repository;
        private readonly ISimplePasswordEncryption<Users> _encryption;

        public UsersService(IUserRepository repository,
                            ISimplePasswordEncryption<Users> encryption)
        {
            this._repository = repository;
            this._encryption = encryption;
        }

        public Users SignUp(Users entity)
        {
            entity.Password = _encryption.HashPassword(entity, entity.Password);
            return this.Add(entity);
        }

        public Users SignIn(string username, string password)
        {
            var user = _repository.GetAll(new UserSignOnSpecificationUser(username)).FirstOrDefault();            
            if (_encryption.VerifyHashedPassword(user, user.Password, password) == PasswordVerificationResult.Failed)
            {
                throw new Exception("Password not accepted");
            }

            return this.GetById(user.UserId);
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
