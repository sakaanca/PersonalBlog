using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.SkillsDtos;
using PersonalBlog.Entities.Dtos.SlidersDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class SkillsService : ISkillsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }



        public async Task<IDataResult<SkillsDto>> Add(SkillsAddDto skillsAddDto)
        {
            if (skillsAddDto != null)
            {
                var skill = _mapper.Map<Skills>(skillsAddDto);
                skill.CreatedTime = DateTime.Now;
                await _unitOfWork.Skill.AddAsync(skill);
                await _unitOfWork.SaveAsync();
                return new DataResult<SkillsDto>(ResultStatus.Success, new SkillsDto { Skills = skill});

            }
            return new DataResult<SkillsDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz.", null);

        }

        public async Task<IResult> Delete(int id)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == id);
            if (skill != null)
            {
                skill.IsDelete = true;
                await _unitOfWork.Skill.UpdateAsync(skill);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata Kayıt bulunamadı !");
           
        }

        public async Task<IDataResult<SkillsDto>> Get(int id)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == id);
            if (skill != null)
            {
               
                return new DataResult<SkillsDto>(ResultStatus.Success, new SkillsDto { Skills = skill});

            }
            return new DataResult<SkillsDto>(ResultStatus.Error, "Hata Kayıt bulunamadı !", null);
        }

        public async Task<IDataResult<SkillsListDto>> GetAll()
        {
            var skill = await _unitOfWork.Skill.GetAllAsync();
            if (skill.Count>0)
            {

                return new DataResult<SkillsListDto>(ResultStatus.Success, new SkillsListDto { Skills = skill });

            }
            return new DataResult<SkillsListDto>(ResultStatus.Error, "Hata Kayıt yok !", null);
        }

        public async  Task<IDataResult<SkillsListDto>> GetAllByNonDelete()
        {
            var skill = await _unitOfWork.Skill.GetAllAsync( x => x.IsDelete == false);
            if (skill.Count > 0)
            {

                return new DataResult<SkillsListDto>(ResultStatus.Success, new SkillsListDto { Skills = skill });

            }
            return new DataResult<SkillsListDto>(ResultStatus.Error, "Hata Kayıt yok !", null);
        }

        public async Task<IDataResult<SkillsListDto>> GetAllByNonDeleteAndActive()
        {
            var skill = await _unitOfWork.Skill.GetAllAsync(x => x.IsDelete == false && x.IsActive== true);
            if (skill.Count > 0)
            {

                return new DataResult<SkillsListDto>(ResultStatus.Success, new SkillsListDto { Skills = skill });

            }
            return new DataResult<SkillsListDto>(ResultStatus.Error, "Hata Kayıt yok !", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == id);
            if (skill != null)
            {
                
                await _unitOfWork.Skill.DeleteAsync(skill);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata Kayıt bulunamadı !");
        }

        public async Task<IDataResult<SkillsDto>> Update(SkillsUpdateDto skillsUpdateDto)
        {
           
            if (skillsUpdateDto != null)
            {
                var skill = _mapper.Map<Skills>(skillsUpdateDto);
                skill.ModifiedTime = DateTime.UtcNow;
                await _unitOfWork.Skill.UpdateAsync(skill);
                await _unitOfWork.SaveAsync();
                return new DataResult<SkillsDto>(ResultStatus.Success, new SkillsDto { Skills= skill});

            }
            return new DataResult<SkillsDto>(ResultStatus.Error, "Hata Kayıt bulunamadı !",null);
        }
    }
}
