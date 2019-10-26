using InterBlock.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Helpers.Configurations
{
    public class Connections
    {
        public string _ConnectionString { get; private set; }
        public Connections(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
    }
}
