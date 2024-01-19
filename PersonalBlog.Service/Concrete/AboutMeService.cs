using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.AboutMeDto;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Entities.Dtos.SummaryDtos;
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
    public class AboutMeService : IAboutMeService

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AboutMeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<IDataResult<AboutMeDto>> Get(int id=1)
        {
            var about = await _unitOfWork.AboutMe.GetAsync(x => x.Id == id);
            if (about != null)
            {

                return new DataResult<AboutMeDto>(ResultStatus.Success, new AboutMeDto { AboutMe = about });

            }
            return new DataResult<AboutMeDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrool ediniz !.", null);
        }

        public async  Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto)
        {
            
            if (aboutMeUpdateDto != null)
            {
                var about = _mapper.Map<AboutMe>(aboutMeUpdateDto);
                await _unitOfWork.AboutMe.UpdateAsync(about);
                await _unitOfWork.SaveAsync();
                return new DataResult<AboutMeDto>(ResultStatus.Success, new AboutMeDto { AboutMe = about });

            }
            return new DataResult<AboutMeDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrool ediniz !.", null);
        }

        
    }
}
