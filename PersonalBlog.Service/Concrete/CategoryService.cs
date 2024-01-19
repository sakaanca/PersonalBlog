using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.CategoryDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }





        public async Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto)
        {
            if (categoryAddDto != null)
            {
                var category = _mapper.Map<Categories>(categoryAddDto);
                await _unitOfWork.Categories.AddAsync(category);
                await _unitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto { Categories = category });

            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgiler hatalıdır!",null);
        }

        public async Task<IResult> Delete(int id)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id == id);

            if (category != null)
            {
               
                await _unitOfWork.Categories.AddAsync(category);
                await _unitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto { Categories = category });

            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgiler hatalıdır!", null);
        }





        public async Task<IDataResult<CategoryDto>> Get(int id)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id == id);

            if (category != null)
            {

               
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto { Categories = category });

            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgiler hatalıdır!", null);




        }





        public async Task<IDataResult<CategoryListDto>> GetAll()
        {

            var categories = await _unitOfWork.Categories.GetAllAsync();

            if (categories.Count>0 )
            {


                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { Categories = categories });

            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata , Kayıt yok!", null);


        }





        public async Task<IDataResult<CategoryListDto>> GetAllByNonDelete()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(x=>x.IsDelete==false);

            if (categories.Count > 0)
            {


                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { Categories = categories });

            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata , Kayıt yok!", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleteAndActive()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(x => x.IsDelete == false && x.IsActive==true);

            if (categories.Count > 0)
            {


                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto { Categories = categories });

            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata , Kayıt yok!", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id==id);

            if (category!= null)
            {

                await _unitOfWork.Categories.DeleteAsync(category);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata , Kayıt yok!", null);

        }

        public async Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto)
        {
           

            if (categoryUpdateDto != null)
            {
                var category = _mapper.Map<Categories>(categoryUpdateDto);
                await _unitOfWork.Categories.AddAsync(category);
                await _unitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto { Categories = category });

            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgiler hatalıdır!", null);
        }
    }
}
