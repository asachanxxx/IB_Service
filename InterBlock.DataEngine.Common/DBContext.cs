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
    public class DBContext
    {
        public DataBaseType _DbType { get; private set; }
        public Connections _Connection { get; private set; }

        private DB2DBContext _DB2DBContext;
        private MSSQLDBContext _MSSQLDBContext;
        private MySqlDBContext _MySqlDBContext;
        private PostgreSQLLDBContext _PostgreSQLLDBContext;

        public iDBContextExtendedBase QueryProcessor { get; private set; }
        public DBContext(DataBaseType DbType, Connections Conn)
        {
            _DbType = DbType;
            _Connection = Conn;
            if (Conn == null || string.IsNullOrEmpty(Conn._ConnectionString))
            {
                throw new Exception("Connection String cannot be an empty value");
            }
            SetContext(_DbType, Conn);
        }

        private void SetContext(DataBaseType DbType, Connections Conn)
        {
            switch (DbType) { 
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

        
    }
}
