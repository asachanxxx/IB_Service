using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Helpers.Utilities
{
    public class MSSQLQueryCreater
    {
        public static string CombineQueryForDelete(string _tableName, string PK_field, int _PK_Value)
        {
            return "DELETE FROM " + _tableName.ToUpper() +
                    " WHERE " + PK_field.ToUpper() + " = " + _PK_Value.ToString();
        }

        public static string CombineQueryForSelectAll(string _tableName, string _Fld_OrderBy_name)
        {
            return "SELECT * FROM " + _tableName.ToUpper() +
                    " ORDER BY " + _Fld_OrderBy_name.ToUpper();
        }

        public static string CombineQueryForSelect(string _tableName, string _Filter_field, int _Field_Value)
        {
            return "SELECT * FROM  " + _tableName.ToUpper() +
                    " WHERE " + _Filter_field.ToUpper() + " = " + _Field_Value.ToString();
        }
    }
}
