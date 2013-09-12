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
    public class GenericRepository<T> : IDataRepository<T>, IDataRepository where T : class
    {
    }
}



    {
        /// <summary>
        /// Data Context object to interact with the db
        /// </summary>
        readonly DbContext _dataContext;
         
        /// <summary>
        /// Public constructor
        /// </summary>
        public GenericRepository()
       {
            //get database connection
            andy680Entities db = new andy680Entities();
 }


    /// <summary>
    /// Generic interface
    /// </summary>
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