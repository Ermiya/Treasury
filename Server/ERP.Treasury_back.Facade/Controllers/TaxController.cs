using Bitspco.Framework.Common.Query;
using ERP.Treasury_back.Common.Entities;
using ERP.Treasury_back.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Facade
{
    public partial class TreasuryController
    {
        public List<TaxGetDto> SelectTax(QueryOptions options) => Select<Tax, TaxGetDto>(options);
        public List<TaxGetDto> GetAllTax() => GetAll<Tax, TaxGetDto>();
        public TaxGetDto GetTaxById(object id) => GetById<Tax, TaxGetDto>(id);
        public TaxGetDto AddTax(TaxAddDto obj) => Add<Tax, TaxGetDto, TaxAddDto>(obj);
        public TaxGetDto ChangeTax(object id, TaxChangeDto obj) => Change<Tax, TaxGetDto, TaxChangeDto>(id, obj);
        public TaxGetDto RemoveTax(object id) => Remove<Tax, TaxGetDto>(id);


    }
}
