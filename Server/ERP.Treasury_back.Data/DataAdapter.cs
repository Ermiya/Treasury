using Bitspco.Framework.Net.Logger;
using Bitspco.Framework.Net.Logger.Contexts;
using ERP.Treasury_back.Common.Interfaces;
using ERP.Treasury_back.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Data
{
    public class DataAdapter : LoggerDataAdapter<PayrollDbContext>, IDataAdapter
    {
        public DataAdapter(PayrollDbContext payrollDbContext, LoggerDbContext loggerDbContext) : base(payrollDbContext, loggerDbContext)
        {

        }
    }
}
