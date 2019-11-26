using Bitspco.Framework.Common.Query;
using Bitspco.Framework.Filters.Security.AntiDos;
using Bitspco.Framework.Filters.Security.Authenticate;
using Bitspco.Framework.Filters.Security.IP;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models;
using ERP.Treasury.Shared.Models.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade
{
    public partial class TreasuryController
    {
        [Auth("(r:Admin|r:Supporter)&p:Bank_Get")]
        public List<BankGetDto> SelectBank(QueryOptions options) => Select<Bank, BankGetDto>(options);
        public List<BankGetDto> GetAllBank() => GetAll<Bank, BankGetDto>();
        public BankGetDto GetBankById(object id) => GetById<Bank, BankGetDto>(id);
        public BankGetDto AddBank(BankAddDto obj) => Add<Bank, BankGetDto, BankAddDto>(obj);
        public BankGetDto ChangeBank(object id, BankAddDto obj) => Change<Bank, BankGetDto, BankAddDto>(id, obj);
       public BankGetDto RemoveBank(object id) => Remove<Bank, BankGetDto>(id);


    }
}
