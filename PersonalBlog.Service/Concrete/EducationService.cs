
using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.EducationDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class EducationService : IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EducationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }





        public async Task<IDataResult<EducationDto>> Add(EducationAddDto educationAddDto)
        {
            if (educationAddDto != null)
            {
                var education = _mapper.Map<Education>(educationAddDto);
                await _unitOfWork.Education.AddAsync(education);
                await _unitOfWork.SaveAsync();
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education });

            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrol ediniz.", null);
            ;
        }

        public async Task<IResult> Delete(int id)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == id);
            if (education != null)
            {
                education.IsDelete = true;
                education.ModifiedTime = DateTime.Now;
                await _unitOfWork.Education.AddAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Hata , Kayıt bulunamadı !");

            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrol ediniz.", null);
        }






        public async Task<IDataResult<EducationDto>> Get(int id)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == id);
            if (education != null)
            {

                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education });

            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata, Kayıt Bulunamadı.", null);
        }







        public async Task<IDataResult<EducationListDto>> GetAll()
        {
            var educations = await _unitOfWork.Education.GetAllAsync();
            if (educations.Count > 0)
            {

                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });

            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, Kayıt Bulunamadı.", null);
        }







        public async Task<IDataResult<EducationListDto>> GetAllByNonDelete()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDelete == false);
            if (educations.Count > 0)
            {

                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });

            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, Kayıt Bulunamadı.", null);
        }






        public async Task<IDataResult<EducationListDto>> GetAllByNonDeleteAndActive()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDelete == false && x.IsActive);
            if (educations.Count > 0)
            {

                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });

            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, Kayıt Bulunamadı.", null);
        }







        public async Task<IResult> HardDelete(int id)
        {
            Education education = await _unitOfWork.Education.GetAsync(X => X.Id == id);
            if (education != null)
            {

                await _unitOfWork.Education.AddAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrol ediniz.");
        }






        public async Task<IDataResult<EducationDto>> Update(EducationUpdateDto educationUpdateDto)
        {
            if (educationUpdateDto != null)
            {
                var education = _mapper.Map<Education>(educationUpdateDto);
                await _unitOfWork.Education.AddAsync(education);
                await _unitOfWork.SaveAsync();
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education });

            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
