using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
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
    public class SummaryService : ISummaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public SummaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SummaryDto>> GetAsync(int id)
        {
            var summary = await _unitOfWork.Summary.GetAsync(x => x.Id == id);
            if (summary != null)
            {
                var summaryDto = _mapper.Map<SummaryDto>(summary);
                return new DataResult<SummaryDto>(ResultStatus.Success, summaryDto);
            }
            return new DataResult<SummaryDto>(ResultStatus.Error, "Hata, Kayıt Bulunamadı!", null);
        }


        public async Task<IDataResult<SummaryDto>> UpdateAsync(SummaryUpdateDto summaryUpdateDto)
        {
            if (summaryUpdateDto != null)
            {
                var summary = _mapper.Map<Summary>(summaryUpdateDto);
                await _unitOfWork.Summary.UpdateAsync(summary);
                await _unitOfWork.SaveAsync();
                return new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto { Summary = summary });
            }
            return new DataResult<SummaryDto>(ResultStatus.Error, "Hata, Girdiğiniz bilgileri kontrool ediniz !.",null);
            
            
            
        }

       
    }
}
