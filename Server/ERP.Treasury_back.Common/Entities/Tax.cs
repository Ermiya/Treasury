using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Common.Entities
{
    [Table("TAXTABLE ")]
    public class Tax : Entity, IAudited
    {
        [Column("TAX_YEAR")]
        public short Year { get; set; }
        [Column("FROM_INCOME")]
        public int FromIncome { get; set; }
        [Column("TO_INCOME")]
        public int ToIncome { get; set; }
        [Column("TAX_PERCENT")]
        public float Present { get; set; }

        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
