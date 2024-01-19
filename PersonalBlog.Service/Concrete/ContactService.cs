using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.ContactInfoDtos;
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
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ContactService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }





        public async Task<IDataResult<ContactInfoDto>> Get(int id)
        {
            var contact = await _unitOfWork.ContactInfo.GetAsync(x => x.Id == id);
            if (contact != null)

            {
                return new DataResult<ContactInfoDto>(ResultStatus.Success, new ContactInfoDto { ContactInfo = contact});


            }
            return new DataResult<ContactInfoDto>(ResultStatus.Error, "Hata , Kayıt Bulunamadı !", null);
        }

        public async Task<IDataResult<ContactInfoDto>> Update(ContactInfoUpdateDto contactInfoUpdateDto)
        {
           
            if (contactInfoUpdateDto != null)

            {
                var contact = _mapper.Map<ContactInfo>(contactInfoUpdateDto);
                await _unitOfWork.ContactInfo.UpdateAsync(contact);
                await _unitOfWork.SaveAsync();
                return new DataResult<ContactInfoDto>(ResultStatus.Success, new ContactInfoDto { ContactInfo = contact });


            }
            return new DataResult<ContactInfoDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz !", null);
        }
    }
}
