using AutoMapper;
using PersonalBlog.Data.Concrete;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.InterestedDtos;
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
    public class InterestedService : IInterestedService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InterestedService(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }







        public async Task<IDataResult<InterestedDto>> Add(InterestedAddDto interestedAddDto)
        {
            if (interestedAddDto != null)
            {
                var interested = _mapper.Map<Interesteds>(interestedAddDto);
                interested.CreatedTime = DateTime.Now;
                await _unitOfWork.Interesteds.AddAsync(interested);
                await _unitOfWork.SaveAsync();

                var interestedDto = _mapper.Map<InterestedDto>(interested);

                return new DataResult<InterestedDto>(ResultStatus.Success, interestedDto);
            }

            // Eğer interestedAddDto null ise, bir hata durumuyla ilgili bilgi döndürülmeli.
            return new DataResult<InterestedDto>(ResultStatus.Error, "Hata, Kayıt yapılamadı !", null);
        }






        

        public async Task<IResult> Delete(int id)
        {
            var interested = await _unitOfWork.Interesteds.GetAsync(x => x.Id == id);
            if (interested != null)
            {
                interested.IsDelete = true;
                await _unitOfWork.Interesteds.UpdateAsync(interested);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Kayıt Bulunamadı !");
        }








        public async Task<IDataResult<InterestedDto>> Get(int id)
        {
            var interested = await _unitOfWork.Interesteds.GetAsync(x => x.Id == id);
            if (interested != null)
            {
                
            }
            return new DataResult<InterestedDto>(ResultStatus.Error, "Hata, Kayıt bulunamadı !", null);
        }








        public async Task<IDataResult<InterestedsListDto>> GetAll()
        {
            var interested= await _unitOfWork.Interesteds.GetAllAsync();
            if (interested != null)

            {
                return new DataResult<InterestedsListDto>(ResultStatus.Success, new InterestedsListDto { Interesteds = interested });

            }
            return new DataResult<InterestedsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);
        }








        public async Task<IDataResult<InterestedsListDto>> GetAllByNonDelete()
        {
            var interested = await _unitOfWork.Interesteds.GetAllAsync(x => x.IsDelete == false);
            if (interested.Count > 0)
            {
                return new DataResult<InterestedsListDto>(ResultStatus.Success, new InterestedsListDto { Interesteds = interested });

            }
            return new DataResult<InterestedsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);
        }







        public async Task<IDataResult<InterestedsListDto>> GetAllByNonDeleteAndActive()
        {

            var interested = await _unitOfWork.Interesteds.GetAllAsync(x => x.IsDelete == false && x.IsActive == true);
            if (interested.Count > 0)
            {
                return new DataResult<InterestedsListDto>(ResultStatus.Success, new InterestedsListDto { Interesteds = interested });

            }
            return new DataResult<InterestedsListDto>(ResultStatus.Error, "Hata , Kayıtlar bulunamadı !", null);
        }







        public async Task<IResult> HardDelete(int id)
        {
            var interested = await _unitOfWork.Interesteds.GetAsync(x => x.Id == id);
            if (interested != null)
            {
                await _unitOfWork.Interesteds.DeleteAsync(interested);
                await _unitOfWork.SaveAsync();// sava ile veri tabanına dahil eder  işlemleri
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Success, "Hata, Kayıt Bulunamadı");
        }







        public async Task<IDataResult<InterestedDto>> Update(InterestedUpdateDto interestedUpdateDto)
        {
            if (interestedUpdateDto != null)
            {
                var interested =_mapper.Map<Interesteds>(interestedUpdateDto);
                await _unitOfWork.Interesteds.UpdateAsync(interested);
                await _unitOfWork.SaveAsync();
                return new DataResult<InterestedDto>(ResultStatus.Success, new InterestedDto { Interesteds = interested });

            }
            return new DataResult<InterestedDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }
    }
}
