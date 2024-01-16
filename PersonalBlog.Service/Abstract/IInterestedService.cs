using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IInterestedService
    {
        Task<IDataResult<InterestedDto>> Get(int id);
        Task<IDataResult<InterestedsListDto>> GetAll();
        Task<IDataResult<InterestedsListDto>> GetAllByNonDelete();
        Task<IDataResult<InterestedsListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<InterestedDto>> Add(InterestedAddDto interestedAddDto);
        Task<IDataResult<InterestedDto>> Update(InterestedUpdateDto interestedUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
