using Hotel_Management_Application.Contracts;
using Hotel_Mgt_System.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Infrastructure.BaseRepositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext _dbContext;
        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
             _dbContext.Add(entity);
        }

        public void Delete(T entity)
        {
         _dbContext.Remove(entity);
        }

        public IQueryable<T> GetAll(bool trackChanges) => !trackChanges ?
                _dbContext.Set<T>().AsNoTracking() :
                _dbContext.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ?
                _dbContext.Set<T>().Where(expression).AsNoTracking() :
                _dbContext.Set<T>().Where(expression);

        public void Update(T entity)
        {
           _dbContext.Update(entity);   
        }
    }
}
