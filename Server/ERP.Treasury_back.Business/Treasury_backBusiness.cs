using ERP.Treasury_back.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Business
{
    public partial class Treasury_backBusiness
    {
        private IDataAdapter adapter;   
        public Treasury_backBusiness(IDataAdapter adapter)
        {
            this.adapter = adapter;
        }
    }
}
