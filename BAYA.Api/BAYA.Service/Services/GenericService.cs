using BAYA.Core.Repositories;
using BAYA.Core.Services;
using BAYA.Core.UnitOfWorks;
using BAYA.Repository.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;
        private readonly IUnitOfWork _unitOfWorks;
        public GenericService(IGenericRepository<T> genericRepository, IUnitOfWork unitOfWorks)
        {
            _genericRepository = genericRepository;
            _unitOfWorks = unitOfWorks;
        }




        public async Task<T> AddAsync(T entity)
        {
            await _genericRepository.AddAsync(entity);
            await _unitOfWorks.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _genericRepository.GetAll().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            var values = _genericRepository.GetByIdAsync(id);
            if (values == null)
            {
                throw new DirectoryNotFoundException($"{typeof(T).Name}({id}) not found");
            }
            return values;
        }

        public IQueryable<T> GetListByFilter(Expression<Func<T, bool>> expression)
        {
            return _genericRepository.GetListByFilter(expression);
        }

        public async Task RemoveAsync(T entity)
        {
            _genericRepository.Remove(entity);
            await _unitOfWorks.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _genericRepository.Update(entity);
            await _unitOfWorks.CommitAsync();
        }
    }
}
