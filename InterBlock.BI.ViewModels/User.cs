using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class User
    {
        public string UserID { get; set; }
        public string UseName { get; set; }
        public string Password { get; set; }
        public string Suffix { get; set; }
        public Status Status { get; set; }
        public UserMode Priority { get; set; }

        public List<Function> Functions;

        public User()
        {
            Functions = new List<Function>();
        }
    }

    public class Function
    {
        public string FunctionName { get; set; }
    }
}
