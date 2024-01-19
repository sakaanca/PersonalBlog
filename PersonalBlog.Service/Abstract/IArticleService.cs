using PersonalBlog.Entities.Dtos.ArticlesDtos;
using PersonalBlog.Entities.Dtos.SkillsDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public  interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int id);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDelete();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<ArticleDto>> Add(ArticleAddDto articleAddDto);
        Task<IDataResult<ArticleDto>> Update(ArticleUpdateDto srticleUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> IncrementRead(int id);// okunan makaleleri birer arttırmak içi kullanılan metod

        Task<IResult> HardDelete(int id);
    }
}
