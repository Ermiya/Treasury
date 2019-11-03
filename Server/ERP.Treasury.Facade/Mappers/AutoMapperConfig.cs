using AutoMapper;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models;
using ERP.Treasury.Shared.Models.Bank;
using ERP.Treasury.Shared.Models.CommonPages;
using ERP.Treasury.Shared.Models.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade.Mappers
{
    public static class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<Document_types, ParrametersForFormConstractionDto>();

                cfg.CreateMap<Tax, TaxGetDto>();
                cfg.CreateMap<TaxAddDto, Tax>();
                cfg.CreateMap<TaxChangeDto, Tax>();

                cfg.CreateMap<Bank, BankGetDto>();
                cfg.CreateMap<BankGetDto, Bank>();
                cfg.CreateMap<BankAddDto, Bank>();
                cfg.CreateMap<Bank, BankAddDto>();




            });
        }

        public static TEntity ToEntity<TEntity, TDto>(this TDto dto)
        {
            return AutoMapper.Mapper.Map<TDto, TEntity>(dto);
        }

        public static TDto ToDto<TEntity, TDto>(this TEntity entity)
        {
            return AutoMapper.Mapper.Map<TEntity, TDto>(entity);
        }
    }
}
