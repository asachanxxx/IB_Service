using InterBlock.Helpers.Configurations;
using InterBlock.Helpers.Enums;
using InterBlock.Helpers.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Repositories.ConfigurationLoaders
{
    public class SQLQueryRepository
    {
        public DataBaseType _DataBaseType { get; set; }
        public List<Queries> AllDbQueries { get; set; }
        JsonSqlLoader jloader;
        public SQLQueryRepository(DataBaseType DataBaseType)
        {
            _DataBaseType = DataBaseType;

            switch (DataBaseType) { 
                case DataBaseType.DB2:
                    jloader = new JsonSqlLoader(MainConfigurationPaths.DB2QueryJsonPath);
                    break;
                case DataBaseType.MSSql:
                    jloader = new JsonSqlLoader(MainConfigurationPaths.MSSQLQueryJsonPath);
                    break;
                case DataBaseType.MySQL:
                    jloader = new JsonSqlLoader(MainConfigurationPaths.MYSQLQueryJsonPath);
                    break;
                case DataBaseType.PostgreSQL:
                    jloader = new JsonSqlLoader(MainConfigurationPaths.PSQLQueryJsonPath);
                    break;
            }
           

        }
        private void LoadJsonQueries()
        {
            AllDbQueries = jloader.LoadSQLQueries().ToList();
        }

        public Queries GetQuery(string Key)
        {
            return AllDbQueries.SingleOrDefault(q => q.QueryDescription.Trim().ToUpper() == Key.Trim().ToUpper());
        }

    }
}
