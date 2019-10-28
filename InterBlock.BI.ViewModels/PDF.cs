using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.BI.ViewModels
{
    public class PDF
    {
        public string PDFID { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Sequence { get; set; }
        public string StatementDate { get; set; }
        public string FullFilePath { get; set; }
        public string FileName { get; set; }
        public string CusReqFilePath { get; set; }
        public string UserEmail { get; set; }
        public string EmailBcc { get; set; }
        public string EmailCC { get; set; }
        public string EmailStatus { get; set; }
        public string PrintStatus { get; set; }
        public string StatementType { get; set; }
        public string CardNo { get; set; }
        public string MaksedCardNo { get; set; }
        public bool BackgroundLayoutEnableForEmail { get; set; }
        public string BackgroundLayoutEnablePDFPath { get; set; }
    }
}
