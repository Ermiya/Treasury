using AutoMapper;
using ERP.Treasury.Common.Entities;
using ERP.Treasury.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Facade.Mappers
{
    public class MapperProfile : Profile
    {
        public static IEnumerable<Profile> GetAllProfiles()
        {
            var types = Assembly.GetAssembly(typeof(MapperProfile)).GetTypes()
                .Where(x => x.IsClass && x.IsPublic && x.IsSubclassOf(typeof(MapperProfile)))
                .ToList();

            foreach (var type in types)
            {
                yield return (Profile)Activator.CreateInstance(type);
            }
        }
    }

    public class BankProfile : MapperProfile
    {
        public BankProfile()
        {
            CreateMap<Bank, BankGetDto>();
            //CreateMap<WorkExperienceAddDto, WorkExperience>();
            //CreateMap<WorkExperienceChangeDto, WorkExperience>();
        }
    }
}
