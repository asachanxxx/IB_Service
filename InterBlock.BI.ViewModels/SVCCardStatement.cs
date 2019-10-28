using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class SVCCardStatement
    {
        public string STMT_SEQ { get; set; }
        public string CARD_NO { get; set; }
        public string CARD_PROD_DESC { get; set; }
        public string STMT_DATE { get; set; }
        public string PRINT_STATUS { get; set; }
        public string PREV_BAL { get; set; }
        public string CLS_BAL { get; set; }
        public string PURCHASES { get; set; }
        public string CASH_ADVANCES { get; set; }
        public string CHARGES { get; set; }
        public string PAYMENTS { get; set; }
        public string INTEREST { get; set; }
        public string DET_STMT_SEQ { get; set; }
        public string TRXN_CURR { get; set; }
        public string BILL_AMT { get; set; }
        public string TRX_TYP { get; set; }
        public string TRXN_DESC { get; set; }
        public string CR_DR { get; set; }
        public string TRX_DATE { get; set; }
        public string SVC_FIRST_NAME { get; set; }
        public string SVC_LAST_NAME { get; set; }
        public string UNMASKED_CARD_NO { get; set; }
        public string MASKED_CARD_NO { get; set; }
        public string CORE_BANK_NO { get; set; }
        public string CUSTOMER_SERIAL_NO { get; set; }
        public string REMAING_BALANCE { get; set; }
        public string TO_STATEMENT_DATE { get; set; }
        public string CARD_BRNACH { get; set; }
        public string CARD_EXPIRY_DATE { get; set; }
        public string CARD_STATUS { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string NAME_ON_CARD { get; set; }
        public string NOT_SETTLE { get; set; }
        public string TOT_CREDIT { get; set; }
        public string TOT_DEBIT { get; set; }

        public CustomerContacts CustomerContact;
        public List<SVCCardStatementDetail> StatementDetails;

        public SVCCardStatement()
        {
            CustomerContact = new CustomerContacts();
            StatementDetails = new List<SVCCardStatementDetail>();
        }
    }
}
