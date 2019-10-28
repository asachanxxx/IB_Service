using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class StatementHeader
    {
        public string STMT_SEQ { get; set; }
        public string ATTR_ID { get; set; }
        public string ATTR_TYP { get; set; }
        public string CRD_NO { get; set; }
        public string CASH_INT { get; set; }
        public string PURCH_INT { get; set; }
        public string OD_CAT { get; set; }
        public string CRD_TYP { get; set; }
        public string TITLE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string CR_LMT { get; set; }
        public string AVBL_LMT { get; set; }
        public string AVBL_CSH_LMT { get; set; }
        public string TOT_MIN_DUE { get; set; }
        public string TOT_AMT_DUE { get; set; }
        public string MIN_DUE { get; set; }
        public string PREV_BAL { get; set; }
        public string PURCHASES { get; set; }
        public string CASH_ADVANCES { get; set; }
        public string PAYMENTS { get; set; }
        public string CHARGES { get; set; }
        public string CLS_BAL { get; set; }
        public string STMT_DATE { get; set; }
        public string DUE_DATE { get; set; }
        public string STMT_PRD_START { get; set; }
        public string STMT_PRD_END { get; set; }
        public string PRINT_STATUS { get; set; }
        public string MANUAL_ADJUSTMENT { get; set; }
        public string CURRENCY_ID { get; set; }
        public string PREV_POINTS { get; set; }
        public string EARNED_POINTS { get; set; }
        public string REDEEMED_POINTS { get; set; }
        public string CLS_POINTS { get; set; }
        public string STMT_TYPE { get; set; }
        public string TOT_CREDIT { get; set; }
        public string TOT_DEBIT { get; set; }
        public string TOT_AMT_PAST_DUE { get; set; }
        public string FullStatementCount { get; set; }
    }
}
