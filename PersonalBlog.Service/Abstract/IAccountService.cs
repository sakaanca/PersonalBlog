using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Entities.Dtos.InterestedDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAccountService
    {
        Task<IDataResult<AccountsDto>> Get(int id);
        Task<IDataResult<AccountsListDto>> GetAll();
        Task<IDataResult<AccountsListDto>> GetAllByNonDelete();
        Task<IDataResult<AccountsListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<AccountsDto>> Add(AccountsAddDto accountsAddDto);
        Task<IDataResult<AccountsDto>> Update(AccountsUpdateDto accountsUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
