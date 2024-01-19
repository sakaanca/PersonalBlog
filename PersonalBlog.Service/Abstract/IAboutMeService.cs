using PersonalBlog.Entities.Dtos.AboutMeDto;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAboutMeService
    {
        Task<IDataResult<AboutMeDto>> Get(int id);
        Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto);
    }
}
