using Dapper;
using Dapper.Contrib.Extensions;
using InterBlock.DataEngine.Common;
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

namespace InterBlock.Repositories.Base
{
    public class ExtendedRepository<T> : DBContextExtendedBase, iRepositoryBase<T> where T : class
    {
        private IBConfiguration _config;
        private string _tablename;

        public ExtendedRepository(IBConfiguration Config, string TableName):base(Config)
        {
            _config = Config;
            _tablename = TableName;
        }

        public async Task<bool> DeleteMulti(IEnumerable<T> Entity)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    foreach (var item in Entity)
                    {
                        var _ret_val = db.DeleteAsync(Entity);
                    }

                    return await Task.FromResult(true);
                }
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> DeleteSingle(T Entity)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = db.DeleteAsync(Entity);
                    return await _ret_val;
                }
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> DeleteSingle(int Id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = await db.ExecuteAsync(MSSQLQueryCreater.CombineQueryForDelete(_tablename, "Id", Id));
                    return _ret_val > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<IEnumerable<T>> FindALLRecords()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = await db.QueryAsync<T>(MSSQLQueryCreater.CombineQueryForSelectAll(_tablename, "Id"));
                    return _ret_val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> FindOneRecord(int _FK_value)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = await db.QuerySingleOrDefaultAsync<T>(MSSQLQueryCreater.CombineQueryForSelect(_tablename, "Id" , _FK_value));
                    return _ret_val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ModifySingle(T Entity)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = db.UpdateAsync(Entity);
                    return await _ret_val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<int> SaveMulti(T Entity, int Action)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveSingle(T Entity, int Action)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_config.Connection._ConnectionString))
                {
                    var _ret_val = await db.InsertAsync(Entity);
                    return  _ret_val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
