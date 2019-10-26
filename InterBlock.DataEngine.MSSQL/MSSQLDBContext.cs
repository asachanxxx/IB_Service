/*
 Author      : S.G Asanga Chandrakumara
 Purpose     : Defined set of extended data accessing functionalities by implementing iDBContextExtendedBase interface
 DateCreated : 21/10/2019 
 DateModified: 21/10/2019
 Note:       : Any changes needs to implement in inherited classes and interfaces.Changing the 
               names and signatures of the methods will affect existing implementations So do with extreme caution 
 */
using Dapper;
using InterBlock.Helpers.Configurations;
using InterBlock.Helpers.Interfaces;
using InterBlock.Helpers.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.DataEngine.MSSQL
{
    public class MSSQLDBContext : iDBContextExtendedBase
    {

        private Connections _Conn;

        public MSSQLDBContext(Connections Conn)
        {
            _Conn = Conn;
        }

        public async Task<int> ExcuteStoredProcedureToSave<T>(string SPName, T Object) where T : class
        {
            try
            {
                var xmlperson = ObjectXMLPurser.ObjectToXMLGeneric<T>(Object);
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@XMLSQL", xmlperson, DbType.String, ParameterDirection.Input);
                    parameter.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    await db.ExecuteAsync(SPName, parameter, commandType: CommandType.StoredProcedure);
                    int rowCount = parameter.Get<int>("@Status");
                    return rowCount;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> QueryMultipleUsingSQLStatement<T>(string SQL) where T : class
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    return await db.QueryAsync<T>(SQL);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> QueryMultipleUsingStoredProcedure<T>(string SPName) where T : class
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    return await db.QueryAsync<T>(SPName, parameter, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> QuerySingleUsingSQLStatement<T>(string SQL) where T : class
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    return await db.QuerySingleOrDefaultAsync<T>(SQL, parameter);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> QuerySingleUsingStoredProcedure<T>(string SPName) where T : class
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    return await db.QuerySingleOrDefaultAsync<T>(SPName, parameter, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TOut>> QueryTypedStoredProcedure<TPassing, TOut>(string SPName, TPassing Object)
            where TPassing : class
            where TOut : class
        {
            try
            {
                var xmlperson = ObjectXMLPurser.ObjectToXMLGeneric<TPassing>(Object);
                using (IDbConnection db = new SqlConnection(_Conn._ConnectionString))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@XMLSQL", xmlperson, DbType.String, ParameterDirection.Input);
                    parameter.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    return await db.QueryAsync<TOut>(SPName, parameter, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
