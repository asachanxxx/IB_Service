using InterBlock.DataEngine.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Repositories.Base
{
    public class test
    {
        public test()
        {
            DBContext context = new DBContext(Helpers.Enums.DataBaseType.MSSql,new Helpers.Configurations.Connections(""));
            var type = context._DbType;
            var connection = context._Connection;

            //Usage
            var result = context.QueryProcessor.ExcuteStoredProcedureToSave<TestClass>("MySPName", new TestClass() { Id = 1, ValueString = "Test", ValueDecimal = 1234 });

            ExtendedRepository<TestClass> db = new ExtendedRepository<TestClass>(new Helpers.Configurations.IBConfiguration() { Connection =  new Helpers.Configurations.Connections("Constr") , DbType = Helpers.Enums.DataBaseType.MSSql }, "Accounts");
            
            
        }


    }

    public class TestClass {
        public int Id { get; set; }
        public string ValueString { get; set; }
        public decimal ValueDecimal { get; set; }

    }
}
