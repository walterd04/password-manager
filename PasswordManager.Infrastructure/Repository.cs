using PasswordManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IRepositoryAsync<T> _asyncRepository;

        public Repository(IRepositoryAsync<T> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public T Add(T entity)
        {
            return Task.Run(async () => await _asyncRepository.Add(entity)).Result;
        }

        public void Delete(T entity)
        {
            Task.Run(async () => await _asyncRepository.Delete(entity));
        }

        public IReadOnlyList<T> GetAll()
        {
            return Task.Run(async () => await _asyncRepository.GetAll()).Result;
        }

        public IReadOnlyList<T> GetAll(ISpecification<T> spec)
        {
            return Task.Run(async () => await _asyncRepository.GetAll(spec)).Result;
        }

        public T GetById(int id)
        {
            return Task.Run(async () => await _asyncRepository.GetById(id)).Result;
        }

        public void Update(T entity)
        {
            Task.Run(async () => await _asyncRepository.Update(entity));
        }
    }
}
