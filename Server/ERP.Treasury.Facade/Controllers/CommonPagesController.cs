using Bitspco.Framework.Common.Query;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models.CommonPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade
{
    public partial class TreasuryController
    {
        public ParrametersForFormConstractionDto GetParrametersForFormConstraction(int id) => GetById<Document_types, ParrametersForFormConstractionDto>(id);

        public ParrametersForFormConstractionDto GetParrametersForFormConstraction2(int id) => GetById2<Document_types, ParrametersForFormConstractionDto>(id);

    }
}
