using AutoMapper;
using Microsoft.Win32.SafeHandles;
using PersonalBlog.Data.Concrete.EntityFramework.Mappings;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Entities.Dtos.AdminDtos;
using PersonalBlog.Entities.Dtos.ArticlesDtos;
using PersonalBlog.Entities.Dtos.CategoryDtos;
using PersonalBlog.Entities.Dtos.CommentsDto;
using PersonalBlog.Entities.Dtos.ContactInfoDtos;
using PersonalBlog.Entities.Dtos.EducationDtos;
using PersonalBlog.Entities.Dtos.ExperiencesDtos;
using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Entities.Dtos.MessagesDtos;
using PersonalBlog.Entities.Dtos.SiteIdentityDtos;
using PersonalBlog.Entities.Dtos.SkillsDtos;
using PersonalBlog.Entities.Dtos.SlidersDtos;
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
            CreateMap<Summary, SummaryUpdateDto>().ReverseMap();// summary den summaryupdatedto çevirme işlemini yaptığımız gibi reversemap ile tam tersi durumunu da yapabilceğimizi söylüyoruz.
            CreateMap<Interesteds, InterestedAddDto>().ReverseMap();
            CreateMap<InterestedUpdateDto, Interesteds>().ReverseMap();
            //
            CreateMap<AccountsAddDto, SocialMediaAccounts>().ReverseMap();
            CreateMap<AccountsUpdateDto, SocialMediaAccounts>().ReverseMap();
            //
            CreateMap<SlidersAddDto,HomePageSliders>().ReverseMap();
            CreateMap<SlidersUpdateDto, HomePageSliders>().ReverseMap();
            //
            CreateMap<SkillsAddDto, Skills>().ReverseMap();
            CreateMap<SkillsUpdateDto, Skills>().ReverseMap();
            //
            CreateMap<ExperiencesAddDto, Experiences>().ReverseMap();
            CreateMap<ExperiencesUpdateDto, Experiences>().ReverseMap();
            //
            CreateMap<MessagesAddDto, Messages>().ReverseMap();
            CreateMap<MessagesUpdateDto,Messages>().ReverseMap();
            //
            CreateMap<SiteIdentityUpdateDto, SiteIdentity>().ReverseMap();
            //
            CreateMap<AboutMeUpdateDto, AboutMe>().ReverseMap();
            //
            CreateMap<AdminUpdateDto, Admin>().ReverseMap();
            //
            CreateMap<EducationAddDto, Education>().ReverseMap();
            CreateMap<EducationUpdateDto, Education>().ReverseMap();
            //
            CreateMap<ContactInfoUpdateDto, ContactInfo>().ReverseMap();
            //
            CreateMap<ArticleAddDto, Articles>().ReverseMap();
            CreateMap<ArticleUpdateDto, Articles>().ReverseMap();
            //
            CreateMap<CategoryAddDto, Categories>().ReverseMap();
            CreateMap<CategoryUpdateDto,Categories>().ReverseMap();
            //
            CreateMap<CommentAddDto,Comments>().ReverseMap();
            CreateMap<CommentUpdateDto, Comments>().ReverseMap();


        }
    }
}
