using Microsoft.Extensions.DependencyInjection;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Data.Concrete;
using PersonalBlog.Data.Concrete.EntityFramework.Contexts;
using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Extensions
{
    public static class CustomServiceCollection
    {
        public static IServiceCollection MyCustomService(this IServiceCollection services)
        {
            services.AddDbContext <BlogContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISummaryService, SummaryService>();
            services.AddScoped<IInterestedService, InterestedService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISkillsService, SkillsService>();
            services.AddScoped<IExperiencesService, ExperiencesService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<ISiteIdentityService, SiteIdentityService>();
            services.AddScoped<IAboutMeService, AboutMeService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IEducationService , EducationService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IArticleService , ArticleService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
