using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class MerchantStatement
    {
        public string STMT_SEQ;
        public string MERCHANT_ID { get; set; }
        public string MERC_DES { get; set; }
        public string PARENT_MERC_ID { get; set; }
        public string STMT_DATE { get; set; }
        public string ACCT_NO { get; set; }
        public string OPENING_BAL { get; set; }
        public string CLOSING_BAL { get; set; }
        public string CURR_ID { get; set; }
        public string PRINT_STATUS { get; set; }
        public string STMT_PRD_START { get; set; }
        public string STMT_PRD_END { get; set; }
        public string MERC_GRP_ID { get; set; }
        public string CARD_NO { get; set; }
        public string NO_OF_CARD_ISSUES { get; set; }
        public string TRXN_DATE { get; set; }
        public string CORE_ACC_NO { get; set; }
        public string ISSUER_BANK { get; set; }
        public string ISSUER_BRANCH { get; set; }
     
    }
}
