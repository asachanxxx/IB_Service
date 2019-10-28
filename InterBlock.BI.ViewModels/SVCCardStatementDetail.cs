using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class SVCCardStatementDetail
    {
        public string ACCOUNT_NO { get; set; }
        public string CARD_NO { get; set; }
        public string NAME_ON_CARD { get; set; }
        public string STMT_SEQ { get; set; }
        public string DET_STMT_SEQ { get; set; }
        public string TRXN_CURR { get; set; }
        public string BILL_AMT { get; set; }
        public string TRX_TYP { get; set; }
        public string TRXN_DESC { get; set; }
        public string CR_DR { get; set; }
        public string TRX_DATE { get; set; }

        public string REFERENCE_NO { get; set; }
        public string MCC { get; set; }
        public string TRANSACTION_TYPE { get; set; }
        public string PORDUCT_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public string AUTH_CODE { get; set; }
        public string POSTING_DATE { get; set; }
        public string TRX_AMOUNT { get; set; }

    }
}
