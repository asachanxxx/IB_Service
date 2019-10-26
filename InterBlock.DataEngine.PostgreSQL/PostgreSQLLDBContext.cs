using InterBlock.Helpers.Configurations;
using InterBlock.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.DataEngine.PostgreSQL
{
    public class PostgreSQLLDBContext : iDBContextExtendedBase
    {
        private Connections _Conn;

        public PostgreSQLLDBContext(Connections Conn)
        {
            _Conn = Conn;
        }

        public Task<int> ExcuteStoredProcedureToSave<T>(string SPName, T Object) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> QueryMultipleUsingSQLStatement<T>(string SQL) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> QueryMultipleUsingStoredProcedure<T>(string SPName) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> QuerySingleUsingSQLStatement<T>(string SQL) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> QuerySingleUsingStoredProcedure<T>(string SPName) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TOut>> QueryTypedStoredProcedure<TPassing, TOut>(string SPName, TPassing Object)
            where TPassing : class
            where TOut : class
        {
            throw new NotImplementedException();
        }

       
    }
}
