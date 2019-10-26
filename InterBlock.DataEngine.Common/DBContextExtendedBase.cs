using InterBlock.DataEngine.DB2;
using InterBlock.DataEngine.MSSQL;
using InterBlock.DataEngine.MySQL;
using InterBlock.DataEngine.PostgreSQL;
using InterBlock.Helpers.Configurations;
using InterBlock.Helpers.Enums;
using InterBlock.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.DataEngine.Common
{
    public abstract class DBContextExtendedBase
    {
        private IBConfiguration _config;

        private DB2DBContext _DB2DBContext;
        private MSSQLDBContext _MSSQLDBContext;
        private MySqlDBContext _MySqlDBContext;
        private PostgreSQLLDBContext _PostgreSQLLDBContext;

        public iDBContextExtendedBase QueryProcessor { get; private set; }

        public DBContextExtendedBase(IBConfiguration config)
        {
            _config = config;
            if (_config == null || string.IsNullOrEmpty(_config.Connection._ConnectionString))
            {
                throw new Exception("Connection String cannot be an empty value");
            }
            SetContext(_config.DbType, _config.Connection);
        }

        private void SetContext(DataBaseType DbType, Connections Conn)
        {
            switch (DbType)
            {
                case DataBaseType.DB2:
                    _DB2DBContext = new DB2DBContext(Conn);
                    QueryProcessor = _DB2DBContext;
                    break;
                case DataBaseType.MSSql:
                    _MSSQLDBContext = new MSSQLDBContext(Conn);
                    QueryProcessor = _MSSQLDBContext;
                    break;
                case DataBaseType.MySQL:
                    _MySqlDBContext = new MySqlDBContext(Conn);
                    QueryProcessor = _MySqlDBContext;
                    break;
                case DataBaseType.PostgreSQL:
                    _PostgreSQLLDBContext = new PostgreSQLLDBContext(Conn);
                    QueryProcessor = _PostgreSQLLDBContext;
                    break;
            }
        }

        //public virtual Task<int> ExcuteStoredProcedureToSave<T>(string SPName, T Object) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<IEnumerable<T>> QueryMultipleUsingSQLStatement<T>(string SQL) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<IEnumerable<T>> QueryMultipleUsingStoredProcedure<T>(string SPName) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<T> QuerySingleUsingSQLStatement<T>(string SQL) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<T> QuerySingleUsingStoredProcedure<T>(string SPName) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual Task<IEnumerable<TOut>> QueryTypedStoredProcedure<TPassing, TOut>(string SPName, TPassing Object)
        //    where TPassing : class
        //    where TOut : class
        //{
        //    throw new NotImplementedException();
        //}
    }
}
