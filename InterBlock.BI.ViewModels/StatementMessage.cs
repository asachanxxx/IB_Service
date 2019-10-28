using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class StatementMessage
    {
        public string MSG_ID { get; set; }
        public string MSG { get; set; }
        public string MSG_TYP { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public string STATUS_CODE { get; set; }
        public string ADDED_BY { get; set; }
        public DateTime ADDED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public DateTime MODIFIED_DATE { get; set; }

    }
}
