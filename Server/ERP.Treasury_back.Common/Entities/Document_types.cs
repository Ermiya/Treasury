using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Common.Entities
{
    [Table("Document_types")]
    public class Document_types 
    {
        [Key]
        public double SRL { get; set; }
        public string DES { get; set; }
        public Nullable<double> PRIORITY { get; set; }
        public Nullable<double> SYSTEM_SRL { get; set; }
        public Nullable<double> ENDDOC { get; set; }
        public string DOCUMENT_TYPES_SRL { get; set; }
        public Nullable<double> VISIBLE { get; set; }
        public string DETAILED_ACCOUNT_TITLE { get; set; }
        public string DETAILED_ACCOUNT_SIDE_TITLE { get; set; }
        public Nullable<double> BACK_DOC { get; set; }
        public string DETAILED_GROUP_LIST { get; set; }
        public string DETAILED_GROUP_SIDE_LIST { get; set; }
        public Nullable<double> BANKDOC_NO_FLAG { get; set; }
        public Nullable<double> REFRENCE_FLAG { get; set; }
        public string DETAILED_ACCOUNT_LIST { get; set; }
        public string DETAILED_ACCOUNT_SIDE_LIST { get; set; }
        public string LOAN_FLAG { get; set; }
        public string REFRENCE_DES { get; set; }
        public string BANK_DATE_FLAG { get; set; }
        public string CHECK_NO_FLAG { get; set; }
        public string NATURE { get; set; }
        public string BANK_NO_TITLE { get; set; }
        public string BANK_DATE_TITLE { get; set; }
    }
}
