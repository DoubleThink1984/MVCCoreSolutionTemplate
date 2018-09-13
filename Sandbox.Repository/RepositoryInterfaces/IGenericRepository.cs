﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sandbox.Repository.RepositoryInterfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity t);
        Task<TEntity> AddAsyn(TEntity t);
        int Count();
        Task<int> CountAsync();
        void Delete(TEntity entity);
        Task DeleteAsyn(TEntity entity);        
        TEntity Find(Expression<Func<TEntity, bool>> match);
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        Task<ICollection<TEntity>> FindByAsyn(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        Task<ICollection<TEntity>> GetAllAsyn();
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> GetAsync(int id);
        void Save();
        Task SaveAsync();
        TEntity Update(TEntity t, object key);
        Task<TEntity> UpdateAsyn(TEntity t, object key);

        void Dispose();
    }
}