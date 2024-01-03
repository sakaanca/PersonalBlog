using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Shared.Data.Concrete.EntityFramework;

namespace PersonalBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfSummaryRepository : EfEntityRepositoryBase<Summary>, ISummaryRepository
    {
        public EfSummaryRepository(DbContext context) : base(context)
        {
        }
    }
}
