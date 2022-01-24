namespace SSRNMFSSN.Repository.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;


    public interface IRepository<T> where T : class
    {

        /// <summary>
        /// Get will return null if the object does not exist.  
        /// Since this is its contract, it must return either the entity or null, so it cannont give you a proxy if the entity is not known to exist.
        /// Get will usually result in a select agains the database, but it will check the session cache and the 2nd level cache first to get the values.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        Task<T> GetByIdAsync(int Id);


        ///// <summary>
        ///// Returns all T objects
        ///// </summary>
        ///// <returns></returns>
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        IEnumerable<T> Query(Expression<Func<T, T>> expression);

        ///// <summary>
        ///// Inserts a record, wraps Insert in a transaction if not already in one.
        ///// </summary>
        ///// <param name="enitity"></param>
        ///// <returns></returns>
        T Add(T entity);

        ///// <summary>
        ///// Remove record, wraps Remove in a transaction if not already in one.
        ///// </summary>
        ///// <param name="entity"></param>
        void Remove(T entity);

        int Count();
        Task<int> CountAsync();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        T Save(T entity, int key);

        T UpdateEntity(T entity);
        
        T SetValues(int id, T entity);

        void SaveChanges();

        /////// <summary>
        /////// Gets Entity by specific criteria
        /////// </summary>
        /////// <param name="where"></param>
        /////// <returns></returns>
        //T WhereToSingle(Expression<Func<T, bool>> where);

        /////// <summary>
        /////// Return true if the criteria matches
        /////// </summary>
        /////// <param name="where"></param>
        /////// <returns></returns>
        //bool Exist(Expression<Func<T, bool>> where);

        /////// <summary>
        /////// Gets list of Entities by specific criteria
        /////// </summary>
        /////// <param name="where"></param>
        /////// <returns></returns>
        //IEnumerable<T> WhereToList(Expression<Func<T, bool>> where);
    }
}