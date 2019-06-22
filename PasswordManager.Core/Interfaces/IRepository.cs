using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        IReadOnlyList<T> GetAll();

        IReadOnlyList<T> GetAll(ISpecification<T> spec);

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
