using PersonalBlog.Data.Abstract;
using PersonalBlog.Data.Concrete.EntityFramework.Contexts;
using PersonalBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete
   
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private EfSummaryRepository _efSummaryRepository;
        private EfInterestedsRepository _efInterestedsRepository;
        private EfSocialMediaAccoutsRepository _efSocialMediaAccoutsRepository;
        private EfHomePageSlidersRepository _efHomePageSlidersRepository;
        private EfSkillsRepository _efSkillsRepository;
        private EfExperiencesRepository _efExperiencesRepository;
        private EfMassagesRepository _efMassagesRepository;
        private EfSiteIdentityRepository _efSiteIdentityRepository;
        private EfAboutMeRepository _efAboutMeRepository;
        private EfAdminRepository _efAdminRepository;
        private EfEducationRepository _efEducationRepository;
        private EfContactInfoRepository _efContactInfoRepository;
        private EfArticlesRepository _efArticlesRepository;
        private EfCategoriesRepository _efCategoriesRepository;
        private EfCommentsRepository _efCommentsRepository;


        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }

        public ISummaryRepository Summary => _efSummaryRepository ?? new EfSummaryRepository(_context);// ?? ile null gelme durumunda yeniden oluşturmasını söyledik.

        public IInterestedsRepository Interesteds => _efInterestedsRepository ?? new EfInterestedsRepository(_context);

        public ISocialMediaAccountsRepository SocialMediaAccounts => _efSocialMediaAccoutsRepository ?? new EfSocialMediaAccoutsRepository(_context);

        public IHomePageSlidersRepository HomePageSliders => _efHomePageSlidersRepository ?? new EfHomePageSlidersRepository(_context);

        public ISkillRepository Skill => _efSkillsRepository ?? new EfSkillsRepository(_context);

        public IExperiencesRepository Experiences => _efExperiencesRepository ?? new EfExperiencesRepository(_context);

        public IMessagesRepository Messages => _efMassagesRepository ?? new EfMassagesRepository(_context);

        public ISiteIdentityRepository SiteIdentity => _efSiteIdentityRepository ?? new EfSiteIdentityRepository(_context);


        public IAboutMeRepository AboutMe => _efAboutMeRepository ?? new EfAboutMeRepository(_context);

        public IAdminReository Admin => _efAdminRepository ?? new EfAdminRepository(_context);

        public IEducationRepository Education => _efEducationRepository ?? new EfEducationRepository(_context);

        public IContactInfoRepository ContactInfo => _efContactInfoRepository ?? new EfContactInfoRepository(_context);

        public IArticleRepository Article => _efArticlesRepository ?? new EfArticlesRepository(_context);

        public ICategoriesRepository Categories => _efCategoriesRepository ?? new EfCategoriesRepository(_context);

        public ICommentsRepository Comments => _efCommentsRepository ?? new EfCommentsRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
