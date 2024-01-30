using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.ExperiencesDtos;
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
    public class ExperiencesService : IExperiencesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExperiencesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }




        public async Task<IDataResult<ExperiencesDto>> Add(ExperiencesAddDto experiencesAddDto)
        {
            if (experiencesAddDto != null)
            {
                var experience = _mapper.Map<Experiences>(experiencesAddDto);
                await _unitOfWork.Experiences.AddAsync(experience);
                await _unitOfWork.SaveAsync();
                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });



            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }







        public async Task<IResult> Delete(int id)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == id);
            if (experience != null)
            {
                experience.IsDelete = true;
                await _unitOfWork.Experiences.AddAsync(experience);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);



            }
            return new Result(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !");
        }






        public async Task<IDataResult<ExperiencesDto>> Get(int id)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == id);
            if (experience != null)
            {

                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });



            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata , Kayıt bulunamadı !", null);

        }



        public async Task<IDataResult<ExperiencesListDto>> GetAll()
        {
            var experience = await _unitOfWork.Experiences.GetAllAsync();
            if (experience.Count>0)
            {

                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experience });



            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata , Kayıt bulunamadı !", null);

        }





        public async Task<IDataResult<ExperiencesListDto>> GetAllByNonDelete()
        {
            var experience = await _unitOfWork.Experiences.GetAllAsync(x=>x.IsDelete==false);
            if (experience.Count > 0)
            {

                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experience });



            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata , Kayıt yok !", null);
        }




        public async Task<IDataResult<ExperiencesListDto>> GetAllByNonDeleteAndActive()
        {
            var experience = await _unitOfWork.Experiences.GetAllAsync(x => x.IsDelete == false && x.IsActive==true);
            if (experience.Count > 0)
            {

                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experience });



            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata , Kayıt yok !", null);
        }





        public async Task<IResult> HardDelete(int id)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == id);
            if (experience != null)
            {
                
                await _unitOfWork.Experiences.DeleteAsync(experience);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);



            }
            return new Result(ResultStatus.Error, "Hata , Kayıt Bulunamadı !");
        }






        public async Task<IDataResult<ExperiencesDto>> Update(ExperiencesUpdateDto experiencesUpdateDto)
        {
           
            if (experiencesUpdateDto != null)
            {
                var experience =  _mapper.Map<Experiences>(experiencesUpdateDto);
                experience.ModifiedTime = DateTime.Now;
                await _unitOfWork.Experiences.UpdateAsync(experience);
                await _unitOfWork.SaveAsync();
                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });



            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }






    }

}
