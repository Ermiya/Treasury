using AutoMapper;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models;
using ERP.Treasury.Shared.Models.CommonPages;
using ERP.Treasury.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade.Mappers
{
    class AutoMapperConfig
    {
        public void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<Document_types, ParrametersForFormConstractionDto>();
                cfg.CreateMap<Tax, BankDto>();
                cfg.CreateMap<TaxAddDto, Tax>();
                cfg.CreateMap<TaxChangeDto, Tax>();
                cfg.CreateMap<Bank, BankGetDto>();


              

            });
        }
    }
}
