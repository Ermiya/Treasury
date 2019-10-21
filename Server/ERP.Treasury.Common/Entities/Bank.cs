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
    [Table("BANK")]
    public class Bank : Entity, IHasCreationTime
    {
        [Required]
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
