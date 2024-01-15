using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace PersonalBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfInterestedsRepository : EfEntityRepositoryBase<Interesteds>, IInterestedsRepository
    {
        private readonly IMapper _mapper;

        public EfInterestedsRepository(DbContext context) : base(context)
        {
            
        }

        public async Task AddAsync(InterestedAddDto interestedAddDto)
        {
            var interested = _mapper.Map<Interesteds>(interestedAddDto);
            interested.CreatedTime = DateTime.Now;
            await base.AddAsync(interested); // base class methodunu çağırarak eklemeyi gerçekleştiriyoruz
        }
    }

}
