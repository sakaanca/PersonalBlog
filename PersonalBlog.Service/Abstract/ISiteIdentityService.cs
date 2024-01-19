using PersonalBlog.Entities.Dtos.SiteIdentityDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface ISiteIdentityService
    {
        Task<IDataResult<SiteIdentityDto>> Get(int id);
        Task<IDataResult<SiteIdentityDto>> Update(SiteIdentityUpdateDto siteIdentityDto);

    }
}
