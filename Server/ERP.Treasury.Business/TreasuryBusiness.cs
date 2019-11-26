using ERP.Treasury.Common.Entities;
using ERP.Treasury.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP.Treasury.Business
{
    public partial class TreasuryBusiness
    {
        private IDataAdapter adapter;   
        public TreasuryBusiness(IDataAdapter adapter)
        {
            this.adapter = adapter;
        }

        public Bank AddBank(Bank entity)
        {
            var b = adapter.Insert<Bank>(entity);
            adapter.SaveChanges();

            return b;
        }
    }
}
