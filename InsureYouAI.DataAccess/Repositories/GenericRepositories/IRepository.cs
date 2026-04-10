using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.GenericRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity?>GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
