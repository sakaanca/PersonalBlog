using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Abstract
{
    public interface IInterestedsRepository : IEntityRepository<Interesteds>
    {
        Task AddAsync(InterestedAddDto interested);
    }
}
