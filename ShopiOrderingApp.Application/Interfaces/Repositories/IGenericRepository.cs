using ShopiOrderingApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopiOrderingApp.Application.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> AddAsync(T entity);
    }
}
