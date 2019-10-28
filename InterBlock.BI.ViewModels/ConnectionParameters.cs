using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class ConnectionParameters
    {
        public string DSN { get; set; }
        public string HostIP { get; set; }
        public string HostPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SchemaName { get; set; }
        public string DatabaseName { get; set; }
        public string CatelogName { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string HostServiceName { get; set; }
        //public DBMS DatabaseManagementSystem { get; set; }
    }
}
