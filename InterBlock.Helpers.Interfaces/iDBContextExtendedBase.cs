/*
 Author      : S.G Asanga Chandrakumara
 Purpose     : Defined set of extended data accessing functionalities across all the contexts
 DateCreated : 21/10/2019 
 DateModified: 21/10/2019
 Note:       : Any changes needs to implement in extended classes and interfaces.Changing the 
               names and signatures of the method will affect existing implementations So do with extreme caution 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Helpers.Interfaces
{
    
    public interface iDBContextExtendedBase
    {
        /// <summary>
        /// Use this method to save an object of given type using StoredProcedure or Function.
        /// </summary>
        /// <typeparam name="T">Class Type of passing object</typeparam>
        /// <param name="SPName">StoredProcedure or Function name</param>
        /// <param name="Object">Passing object Value</param>
        /// <returns></returns>
        Task<int> ExcuteStoredProcedureToSave<T>(string SPName, T Object) where T : class;
        /// <summary>
        /// Use this method to Query and get multiple result set using a given passing type and using a Sql statement
        /// </summary>
        /// <typeparam name="T">Class Type of passing object</typeparam>
        /// <param name="SQL">Sql Statement</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryMultipleUsingSQLStatement<T>(string SQL) where T : class;
        /// <summary>
        /// Use this method to Query and get multiple result set using a given passing type and using StoredProcedure or Function. 
        /// </summary>
        /// <typeparam name="T">Class Type of passing object</typeparam>
        /// <param name="SPName">StoredProcedure or Function name</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryMultipleUsingStoredProcedure<T>(string SPName) where T : class;
        /// <summary>
        /// Use this method to Query and get single result  using a given passing type and using Sql statement.
        /// </summary>
        /// <typeparam name="T">Class Type of passing object</typeparam>
        /// <param name="SQL">Sql Statement</param>
        /// <returns></returns>
        Task<T> QuerySingleUsingSQLStatement<T>(string SQL) where T : class;
        /// <summary>
        /// Use this method to Query and get single result  using a given passing type and using StoredProcedure or Function. 
        /// </summary>
        /// <typeparam name="T">Class Type of passing object</typeparam>
        /// <param name="SPName">StoredProcedure or Function name</param>
        /// <returns></returns>
        Task<T> QuerySingleUsingStoredProcedure<T>(string SPName) where T : class;
        /// <summary>
        /// This method can be used to Return a List of a given type by passing a object of given type using a StoredProcedure or Function
        /// </summary>
        /// <typeparam name="TPassing">Class Type of passing object </typeparam>
        /// <typeparam name="TOut">Class Type of return object</typeparam>
        /// <param name="SPName">StoredProcedure or Function name</param>
        /// <param name="Object">Passing object Value</param>
        /// <returns></returns>
        Task<IEnumerable<TOut>> QueryTypedStoredProcedure<TPassing, TOut>(string SPName, TPassing Object)
            where TOut : class
            where TPassing : class;
    }
}
