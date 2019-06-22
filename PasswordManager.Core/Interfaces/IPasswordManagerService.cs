using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Interfaces
{
    public interface IPasswordManagerService
    {
        Entities.PasswordManager GetById(int id);
        IReadOnlyList<Entities.PasswordManager> GetAll();
        IReadOnlyList<Entities.PasswordManager> GetAll(ISpecification<Entities.PasswordManager> specification);
        Entities.PasswordManager Add(Entities.PasswordManager entity);
        void Update(Entities.PasswordManager entity);
        void Delete(Entities.PasswordManager entity);
    }
}
