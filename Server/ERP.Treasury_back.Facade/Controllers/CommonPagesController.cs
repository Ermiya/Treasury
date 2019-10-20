using Bitspco.Framework.Common.Query;
using ERP.Treasury_back.Common.Entities;
using ERP.Treasury_back.Shared.Models.CommonPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Facade
{
    public partial class TreasuryController
    {
        public ParrametersForFormConstractionDto GetParrametersForFormConstraction(int id) => GetById<Document_types, ParrametersForFormConstractionDto>(id);

        public Document_types GetParrametersForFormConstraction2(int id) => GetById2<Document_types>(id);

    }
}
