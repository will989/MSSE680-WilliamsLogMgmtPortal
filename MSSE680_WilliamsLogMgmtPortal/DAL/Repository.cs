 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using System.Data.Entity;
using System.Configuration;

namespace MSSE680_WilliamsLogMgmtPortal
{
    public class DataRepository<T> : IDataRepository<T>, IDataRepository 
        where T : class
    {
        
        //for communicating with the database
        readonly DbContext dataContext;

        public DataRepository()
        {
            //instantiate the datacontext by reading the connection string
            dataContext = 
                new DbContext(ConfigurationManager.ConnectionStrings["andy680entities"].ConnectionString);

        }
        
        //dispose method
        public void Dispose()
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }//end dispose

        
        // uses generics and returns a collection of objects
        // by passing in a column name and the column's value
        // Takes a string and an integer as parameters
        public virtual IQueryable<T> GetBySpecificKey(string KeyName, int KeyVal)
        {

            var itemParameter = Expression.Parameter(typeof(T), "item");

            /*Lambda expression is an anonymous function
            http://msdn.microsoft.com/en-us/library/bb397951.aspx
            */
            var whereExpression = Expression.Lambda<Func<T, bool>>
                (
                Expression.Equal(
                    Expression.Property(itemParameter,KeyName),
                    Expression.Constant(KeyVal)
                    ),
                new[] { itemParameter }
                );
            try
            {
                return GetAll().Where(whereExpression).AsQueryable();
            }
            catch
            {
                return null;
            }

        }

        // uses generics and returns a collection of objects
        // by passing in a column name and the column's value
        // Takes two strings as parameters
        public virtual IQueryable<T> GetBySpecificKey(string KeyName, string KeyVal)
        {

            var itemParameter = Expression.Parameter(typeof(T), "item");
            var whereExpression = Expression.Lambda<Func<T, bool>>
                (
                Expression.Equal(
                    Expression.Property(itemParameter,KeyName),
                    Expression.Constant(KeyVal)
                    ),
                new[] { itemParameter }
                );
            try
            {
                return GetAll().Where(whereExpression).AsQueryable();
            }
            catch
            {
                return null;
            }

        }

        
        // Returns all the records from a table
        public virtual IQueryable<T> GetAll()
        {
            //this returns a Set of objects
            return dataContext.Set<T>().AsQueryable();
        }

        // Performs an insert into the table
        public virtual void Insert(T entity)
        {
            // adds and saves
            dataContext.Set<T>().Add(entity);
            dataContext.SaveChanges();
        }

        // Delete record from table
        public virtual void Delete(T entity)
        {
            var entry = dataContext.Entry(entity);
            if (entry != null)
            {
                entry.State = System.Data.EntityState.Deleted;
            }
            else
            {
                dataContext.Set<T>().Attach(entity);
            }
            // delete and save changes
            dataContext.Entry(entity).State = System.Data.EntityState.Deleted;
            dataContext.SaveChanges();

        }
        
        // perform update to table and save changes
        public virtual void Update(T entity)
        {
            dataContext.Set<T>().Attach(entity);
            dataContext.Entry(entity).State = System.Data.EntityState.Modified;
            dataContext.SaveChanges();
        }

        IQueryable IDataRepository.GetAll()
        {
            return GetAll();
        }
        void IDataRepository.Insert(object entity)
        {
            Insert((T)entity);
        }
        void IDataRepository.Update(object entity)
        {
            Update((T)entity);
        }
        void IDataRepository.Delete(object entity)
        {
            Delete((T)entity);
        }

        IQueryable IDataRepository.GetBySpecificKey(string KeyName, string KeyVal)
        {
            return GetBySpecificKey(KeyName, KeyVal);
        }

        IQueryable IDataRepository.GetBySpecificKey(string KeyName, int KeyVal)
        {
            return GetBySpecificKey(KeyName, KeyVal);
        }
    }

    /// <summary>
    /// Generic interface
    /// </summary>
    /// <typeparam name="T">Type of entity</typeparam>
    public interface IDataRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetBySpecificKey(string KeyName, string KeyVal);
        IQueryable<T> GetBySpecificKey(string KeyName, int KeyVal);
    }
    /// <summary>
    /// Generic interface
    /// </summary>
    public interface IDataRepository
    {
        IQueryable GetAll();
        void Insert(object entity);
        void Update(object entity);
        void Delete(object entity);
        IQueryable GetBySpecificKey(string KeyName, string KeyVal);
        IQueryable GetBySpecificKey(string KeyName, int KeyVal);
    }
}
