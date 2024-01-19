using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.ArticlesDtos;
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
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }



        public async Task<IDataResult<ArticleDto>> Add(ArticleAddDto articleAddDto)
        {
            if (articleAddDto != null)
            {
                var article = _mapper.Map<ArticleAddDto>(articleAddDto);
                await _unitOfWork.Article.AddAsync(article);
                await _unitOfWork.SaveAsync();
                return new DataResult<ArticleDto>(ResultStatus.Error, new ArticleDto { Articles = article });

            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                article.IsDelete = true;
                article.ModifiedTime=DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
                  

            }

            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
            
        }

        public async Task<IDataResult<ArticleDto>> Get(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id, x=>x.Categories, x=>x.Comments);
            if (article != null)
            {
               
              
                return new DataResult<ArticleDto>(ResultStatus.Error, new ArticleDto { Articles = article });

            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Hata , Kayıt Bulunamadı !", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var article = await _unitOfWork.Article.GetAllAsync(null, x=>x.Categories);
            if (article.Count>0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, new ArticleListDto { Articles = article });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IDataResult<ArticleListDto>> GetAllByNonDelete()
        {
            var article = await _unitOfWork.Article.GetAllAsync(x => x.IsDelete == false, x =>x.Categories);
            if (article.Count>0)
            {


                return new DataResult<ArticleListDto>(ResultStatus.Error, new ArticleListDto { Articles = article });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActive()
        {
            var article = await _unitOfWork.Article.GetAllAsync(x => x.IsDelete == false && x.IsActive == true, x => x.Categories);
            if (article.Count > 0)
            {


                return new DataResult<ArticleListDto>(ResultStatus.Error, new ArticleListDto { Articles = article });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IResult> HardDelete(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);


            }

            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
        }








        public async Task<IResult> IncrementRead(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                article.ViewsCount += 1;
                article.ModifiedTime = DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);


            }

            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
        }







        public async Task<IDataResult<ArticleDto>> Update(ArticleUpdateDto articleUpdateDto)
        {
            if (articleUpdateDto != null)
            {
                var article = _mapper.Map<Articles>(articleUpdateDto);
                await _unitOfWork.Article.AddAsync(article);
                await _unitOfWork.SaveAsync();
                return new DataResult<ArticleDto>(ResultStatus.Error, new ArticleDto { Articles = article });

            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }
    }
}
