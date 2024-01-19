using PersonalBlog.Entities.Dtos.AboutMeDto;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Entities.Dtos.AdminDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAdminService
    {
        Task<IDataResult<AdminDto>> Get(int id);
        Task<IDataResult<AdminDto>> Update(AdminUpdateDto adminUpdateDto);
    }
}
