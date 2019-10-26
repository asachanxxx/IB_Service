using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.Models
{
    [Table("Accounts")]
    public class Accounts
    {
        public int Id { get; set; }

        public string CARD_NO { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string BANK_CODE { get; set; }
        public string BRANCH_CODE { get; set; }
        public string ACCOUNT_TYPE { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string NODE_ID { get; set; }
        public string STATUS_CODE { get; set; }
        public string ADDED_BY { get; set; }
        public string ADDED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public string MODIFIED_DATE { get; set; }
        public string LNK_NO { get; set; }
        public string DISPLAY_ACCT_LABEL { get; set; }
    }

    public class AccountsEssentialsVM
    {
        public int Id { get; set; }

        public string CARD_NO;
        public string ACCOUNT_NO { get; set; }
        public string BANK_CODE { get; set; }
        public string BRANCH_CODE { get; set; }
    }
}
