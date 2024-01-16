using PersonalBlog.Entities.Dtos.ExperiencesDtos;
using PersonalBlog.Entities.Dtos.SlidersDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public  interface IExperiencesService
    {
        Task<IDataResult<ExperiencesDto>> Get(int id);
        Task<IDataResult<ExperiencesListDto>> GetAll();
        Task<IDataResult<ExperiencesListDto>> GetAllByNonDelete();
        Task<IDataResult<ExperiencesListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<ExperiencesDto>> Add(ExperiencesAddDto experiencesAddDto);
        Task<IDataResult<ExperiencesDto>> Update(ExperiencesUpdateDto experiencesUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
