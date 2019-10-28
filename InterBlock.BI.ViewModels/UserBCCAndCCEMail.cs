using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class UserBCCAndCCEMail
    {
        public string BCCEmail { get; set; }
        public string CCEmail { get; set; }
        public List<BCCAndCCMail> BCCs { get; set; }
        public List<BCCAndCCMail> CCs { get; set; }

        public UserBCCAndCCEMail()
        {
            BCCs = new List<BCCAndCCMail>();
            CCs = new List<BCCAndCCMail>();
        }
    }

    public class BCCAndCCMail
    {
        public string BccCCMail { get; set; }
    }
}
