using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Shared.Models.Tax
{
    public class TaxAddDto
    {
        public short Year { get; set; }
        public int FromIncome { get; set; }
        public int ToIncome { get; set; }
        public float Present { get; set; }
    }
}
