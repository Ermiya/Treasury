using Bitspco.Framework.Net.Data;
using Bitspco.Framework.Net.Logger;
using Bitspco.Framework.Net.Logger.Contexts;
using ERP.Treasury.Common.Interfaces;
using ERP.Treasury.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Data
{
    //public class DataAdapter : LoggerDataAdapter<TreasuryDbContext>, IDataAdapter
    public class DataAdapter : BaseDataAdapter<TreasuryDbContext>, IDataAdapter
    {
        //public DataAdapter(TreasuryDbContext payrollDbContext, LoggerDbContext loggerDbContext) : base(payrollDbContext, loggerDbContext)
        public DataAdapter(TreasuryDbContext payrollDbContext) : base(payrollDbContext)
        {

        }
    }
}
