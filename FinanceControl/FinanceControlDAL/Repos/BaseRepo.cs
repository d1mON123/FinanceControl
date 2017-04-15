using FinanceControlDAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceControlDAL.Repos
{
    public abstract class BaseRepo<T> : IDisposable where T : class, new()
    {
        public FinanceControlEntities Context { get; } = new FinanceControlEntities();
        protected DbSet<T> Table;
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Context.Dispose();
            }
            disposed = true;
        }

        internal int SaveChanges()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (CommitFailedException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<int> SaveChangesAsync()
        {
            try
            {
                return await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (CommitFailedException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T GetOne(int? id) => Table.Find(id);

        public Task<T> GetOneAsync(int? id) => Table.FindAsync(id);

        public List<T> GetAll() => Table.ToList();

        public Task<List<T>> GetAllAsync() => Table.ToListAsync();

        public List<T> ExecuteQuery(string sql) => Table.SqlQuery(sql).ToList();

        public Task<List<T>> ExecuteQueryAsync(string sql) => Table.SqlQuery(sql).ToListAsync();

        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects) => Table.SqlQuery(sql, sqlParametersObjects).ToList();

        public Task<List<T>> ExecuteQueryAsync(string sql, object[] sqlParametersObjects) => Table.SqlQuery(sql, sqlParametersObjects).ToListAsync();

        public int Add(T entity)
        {
            Table.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(T entity)
        {
            Table.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<T> entities)
        {
            Table.AddRange(entities);
            return SaveChanges();
        }

        public Task<int> AddRangeAsync(IList<T> entities)
        {
            Table.AddRange(entities);
            return SaveChangesAsync();
        }

        public int Save(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }


    }
}
