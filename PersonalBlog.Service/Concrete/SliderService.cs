using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Entities.Dtos.SlidersDtos;
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
    public class SliderService : ISliderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SliderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }





        public async Task<IDataResult<SlidersDto>> Add(SlidersAddDto slidersAddDto)
        {
            if (slidersAddDto != null)
            {
                var slider = _mapper.Map<HomePageSliders>(slidersAddDto);
                await _unitOfWork.HomePageSliders.AddAsync(slider);
                await _unitOfWork.SaveAsync();
                return new DataResult<SlidersDto>(ResultStatus.Success, new SlidersDto { Sliders = slider });

            }
            return new DataResult<SlidersDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }






        public async Task<IResult> Delete(int id)
        {
            var slider = await _unitOfWork.HomePageSliders.GetAsync(x => x.Id == id);
            if (slider != null)
            {
                slider.IsDelete = true;
                await _unitOfWork.HomePageSliders.UpdateAsync(slider);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);


            }
            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
        }






        public async Task<IDataResult<SlidersDto>> Get(int id)
        {
            var slider = await _unitOfWork.HomePageSliders.GetAsync(x => x.Id == id);
            if (slider != null)
            {
              
                return new DataResult<SlidersDto>(ResultStatus.Success, new SlidersDto { Sliders = slider});


            }
            return new DataResult<SlidersDto>(ResultStatus.Error, "Hata , Kayıt bulunamadı !", null);
        }






        public async Task<IDataResult<SlidersListDto>> GetAll()
        {
            var sliders = await _unitOfWork.HomePageSliders.GetAllAsync();
            if (sliders.Count>0)
            {
                return new DataResult<SlidersListDto>(ResultStatus.Success, new SlidersListDto { Sliders = sliders });

            }
            return new DataResult<SlidersListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IDataResult<SlidersListDto>> GetAllByNonDelete()
        {
            var sliders = await _unitOfWork.HomePageSliders.GetAllAsync( x=> x.IsDelete == false);
            if (sliders.Count > 0)
            {
                return new DataResult<SlidersListDto>(ResultStatus.Success, new SlidersListDto { Sliders = sliders });

            }
            return new DataResult<SlidersListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IDataResult<SlidersListDto>> GetAllByNonDeleteAndActive()
        {
            var sliders = await _unitOfWork.HomePageSliders.GetAllAsync(x => x.IsDelete == false && x.IsActive==true);
            if (sliders.Count > 0)
            {
                return new DataResult<SlidersListDto>(ResultStatus.Success, new SlidersListDto { Sliders = sliders });

            }
            return new DataResult<SlidersListDto>(ResultStatus.Error, "Hata , Kayıt Yok !", null);
        }






        public async Task<IResult> HardDelete(int id)
        {
            var slider = await _unitOfWork.HomePageSliders.GetAsync(x => x.Id == id);
            if (slider != null)
            {
               
                await _unitOfWork.HomePageSliders.DeleteAsync(slider);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata , Kayıt Bulunamadı !");
        }






        public  async Task<IDataResult<SlidersDto>> Update(SlidersUpdateDto slidersUpdateDto)
        {
            if (slidersUpdateDto != null)
            {
                var slider = _mapper.Map<HomePageSliders>(slidersUpdateDto);
                slider.ModifiedTime =DateTime.Now;
                await _unitOfWork.HomePageSliders.UpdateAsync(slider);
                await _unitOfWork.SaveAsync();
                return new DataResult<SlidersDto>(ResultStatus.Success, new SlidersDto { Sliders = slider });

            }
            return new DataResult<SlidersDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }





    }
}
