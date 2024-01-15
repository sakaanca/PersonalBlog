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
        public async Task<IDataResult<InterestedsListDto>> Add(InterestedAddDto interestedAddDto)
        {
            if (interestedAddDto != null)
            {
                var interested = _mapper.Map<Interesteds>(interestedAddDto);
                interested.CreatedTime = DateTime.Now;
                await _unitOfWork.Interesteds.AddAsync(interested);
                await _unitOfWork.SaveAsync();

                var interestedDto = _mapper.Map<InterestedsListDto>(interested);

                return new DataResult<InterestedsListDto>(ResultStatus.Success, interestedDto);
            }

            // Eğer interestedAddDto null ise, bir hata durumuyla ilgili bilgi döndürülmeli.
            return new DataResult<InterestedsListDto>(ResultStatus.Error, "Hata, Kayıt yapılamadı !", null);
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

        public Task<IDataResult<InterestedsListDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<InterestedsListDto>> GetAllByNonDelete()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<InterestedsListDto>> GetAllByNonDeleteAndActive()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<InterestedsListDto>> Update(InterestedUpdateDto interestedUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
