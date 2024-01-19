using PersonalBlog.Entities.Dtos.AboutMeDto;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Entities.Dtos.ContactInfoDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IContactService
    {
        Task<IDataResult<ContactInfoDto>> Get(int id);
        Task<IDataResult<ContactInfoDto>> Update(ContactInfoUpdateDto contactInfoUpdateDto);
    }
}
