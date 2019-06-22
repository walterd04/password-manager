using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Core.Interfaces
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<IReadOnlyList<T>> GetAll(ISpecification<T> spec);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
