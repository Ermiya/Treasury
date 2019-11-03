using Bitspco.Framework.Common.Query;
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
        public List<BankGetDto> SelectBank(QueryOptions options) => Select<Bank, BankGetDto>(options);
        public List<BankGetDto> GetAllBank() => GetAll<Bank, BankGetDto>();
        public BankGetDto GetBankById(object id) => GetById<Bank, BankGetDto>(id);
        public BankGetDto AddBank(BankAddDto obj) => Add<Bank, BankGetDto, BankAddDto>(obj);
        //public TaxGetDto ChangeTax(object id, TaxChangeDto obj) => Change<Tax, TaxGetDto, TaxChangeDto>(id, obj);
        //public TaxGetDto RemoveTax(object id) => Remove<Tax, TaxGetDto>(id);


    }
}
