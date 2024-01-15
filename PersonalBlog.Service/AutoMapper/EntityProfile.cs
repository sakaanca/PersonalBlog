using AutoMapper;
using Microsoft.Win32.SafeHandles;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Entities.Dtos.SummaryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.AutoMapper
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Summary,SummaryUpdateDto>().ReverseMap();// summary den summaryupdatedto çevirme işlemini yaptığımız gibi reversemap ile tam tersi durumunu da yapabilceğimizi söylüyoruz.
            CreateMap<Interesteds, InterestedAddDto>().ReverseMap();
            CreateMap<InterestedUpdateDto, Interesteds>().ReverseMap();

        }
    }
}
