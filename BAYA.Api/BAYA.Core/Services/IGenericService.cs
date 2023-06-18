using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetListByFilter(Expression<Func<T, bool>> expression);
    }
}
