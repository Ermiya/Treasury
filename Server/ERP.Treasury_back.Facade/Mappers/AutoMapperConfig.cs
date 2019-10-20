using AutoMapper;
using ERP.Treasury_back.Common.Entities;
using ERP.Treasury_back.Shared.Models.CommonPages;
using ERP.Treasury_back.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Facade.Mappers
{
    class AutoMapperConfig
    {
        public void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<Document_types, ParrametersForFormConstractionDto>();
                cfg.CreateMap<Tax, TaxGetDto>();
                cfg.CreateMap<TaxAddDto, Tax>();
                cfg.CreateMap<TaxChangeDto, Tax>();


              

            });
        }
    }
}
