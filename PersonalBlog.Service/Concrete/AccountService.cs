using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }






        public async Task<IDataResult<AccountsDto>> Add(AccountsAddDto accountsAddDto)
        {
            if (accountsAddDto != null)
            {
                var account = _mapper.Map<SocialMediaAccounts>(accountsAddDto);
                await _unitOfWork.SocialMediaAccounts.AddAsync(account);
                await _unitOfWork.SaveAsync();
                return new DataResult<AccountsDto>(ResultStatus.Success, new AccountsDto { SocialMediaAccounts= account});

            }
            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);

        }







        public async Task<IResult> Delete(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                account.IsDelete = true;
                await _unitOfWork.SocialMediaAccounts.UpdateAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata , Kayıt buunamadı !");
        }








        public async Task<IDataResult<AccountsDto>> Get(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                return new DataResult<AccountsDto>(ResultStatus.Success, new AccountsDto { SocialMediaAccounts = account});

            }
            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata ,Kayıt bulunamadı !", null);
        }








        public async Task<IDataResult<AccountsListDto>> GetAll()
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAllAsync();
            if (account.Count > 0)
            {
                return new DataResult<AccountsListDto>(ResultStatus.Success,new AccountsListDto { SocialMediaAccounts = account });

            }
            return new DataResult<AccountsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);

        }







        public async Task<IDataResult<AccountsListDto>> GetAllByNonDelete()
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAllAsync(x=>x.IsDelete== false);
            if (account.Count > 0)
            {
                return new DataResult<AccountsListDto>(ResultStatus.Success, new AccountsListDto { SocialMediaAccounts = account });

            }
            return new DataResult<AccountsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);
        }







        public async Task<IDataResult<AccountsListDto>> GetAllByNonDeleteAndActive()
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAllAsync(x => x.IsDelete == false && x.IsActive== true);
            if (account.Count > 0)
            {
                return new DataResult<AccountsListDto>(ResultStatus.Success, new AccountsListDto { SocialMediaAccounts = account });

            }
            return new DataResult<AccountsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);
        }







        public async Task<IResult> HardDelete(int id)
        {
            var account = await _unitOfWork.SocialMediaAccounts.GetAsync(x => x.Id == id);
            if (account != null)
            {
                await _unitOfWork.SocialMediaAccounts.DeleteAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
        }






        public async Task<IDataResult<AccountsDto>> Update(AccountsUpdateDto accountsUpdateDto)
        {
            if (accountsUpdateDto != null)
            {
                var account = _mapper.Map<SocialMediaAccounts>(accountsUpdateDto);
                account.ModifiedTime = DateTime.Now;
                await _unitOfWork.SocialMediaAccounts.UpdateAsync(account);
                await _unitOfWork.SaveAsync();
                return new DataResult<AccountsDto>(ResultStatus.Success,new AccountsDto { SocialMediaAccounts = account });
            }
            return new DataResult<AccountsDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgiler hatalıdır !", null);
        }






    }
}
