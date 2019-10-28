using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class MerchantStatementDetail
    {
        public string STMT_SEQ { get; set; }
        public string MERCHANT_ID { get; set; }
        public string TRXN_DATE { get; set; }
        public string TRXN_TYP { get; set; }
        public string TRXN_TYP_DESC { get; set; }
        public string POST_DATE { get; set; }
        public string TRXN_AMNT { get; set; }
        public string CMSN_AMNT { get; set; }
        public string CHRG_AMNT { get; set; }
        public string TMNL_ID { get; set; }
        public string NTWK_TYP { get; set; }
        public string STMT_DATE { get; set; }
        public string BATCH_ID { get; set; }
        public string TRXN_COUNT { get; set; }
        public string MCHNT_AMNT { get; set; }
        public string MERC_ORDER { get; set; }

    }
}
