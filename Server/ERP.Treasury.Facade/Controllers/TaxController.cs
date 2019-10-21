using Bitspco.Framework.Common.Query;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade
{
    public partial class TreasuryController
    {
        public List<BankDto> SelectTax(QueryOptions options) => Select<Tax, BankDto>(options);
        public List<BankDto> GetAllTax() => GetAll<Tax, BankDto>();
        public BankDto GetTaxById(object id) => GetById<Tax, BankDto>(id);
        public BankDto AddTax(TaxAddDto obj) => Add<Tax, BankDto, TaxAddDto>(obj);
        public BankDto ChangeTax(object id, TaxChangeDto obj) => Change<Tax, BankDto, TaxChangeDto>(id, obj);
        public BankDto RemoveTax(object id) => Remove<Tax, BankDto>(id);


    }
}
