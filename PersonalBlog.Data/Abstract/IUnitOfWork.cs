using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    // bütün repository sınıflarımızı tek bir sınıf içerisinde kontrol etmemizi sağlar. Save etme işlemlerini istediğimiz zaman yapmamızı sağlar. örneğin kategory göndeririz ve sonrasında makale göndeririz bu iki işlemin aynı anda veri tabanına göndermek istediğimizde kullanılır.
    {
        ISummaryRepository Summary { get; }
        IInterestedsRepository Interesteds { get; }
        ISocialMediaAccountsRepository SocialMediaAccounts { get; }
        IHomePageSlidersRepository HomePageSliders { get; }
        ISkillRepository Skill { get; }
        IExperiencesRepository Experiences { get; }
        IMessagesRepository Messages { get; }
        ISiteIdentityRepository SiteIdentity { get; }
        IAboutMeRepository AboutMe { get; }
        IAdminReository Admin { get; }
        IEducationRepository Education { get; }
        IContactInfoRepository ContactInfo { get; }
        IArticleRepository Article { get; }
        ICategoriesRepository Categories { get; }
        ICommentsRepository Comments { get; }

        Task<int> SaveAsync();



    }
}
