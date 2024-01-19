using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.MessagesDtos;
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


    public class MessagesService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MessagesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<MessagesDto>> Add(MessagesAddDto messagesAddDto)
        {
            if (messagesAddDto != null)
            {
                var message = _mapper.Map<Messages>(messagesAddDto);
                await _unitOfWork.Messages.AddAsync(message);
                await _unitOfWork.SaveAsync();
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });

            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata , Girdiğiniz Bilgileri Kontrol Ediniz ", null);


        }

        public async Task<IResult> Delete(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);
            if (message != null)
            {
                message.IsDelete = true;
                await _unitOfWork.Messages.UpdateAsync(message);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata , Kayıt Bulunamadı !");
        }

        public async Task<IDataResult<MessagesDto>> Get(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);

            if (message != null)
            {
               
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });

            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata , Kayıt Bulunamadı ", null);
        }






        public async Task<IDataResult<MessagesListDto>> GetAll()
        {
            var message = await _unitOfWork.Messages.GetAllAsync();

            if (message != null)
            {

                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = message });

            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata , Kayıt Yok ", null);
        }







        public async Task<IDataResult<MessagesListDto>> GetAllByNonDelete()
        {
            var message = await _unitOfWork.Messages.GetAllAsync( x=>x.IsDelete == false);

            if (message.Count>0)
            {

                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = message });

            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata , Kayıt Yok ", null);
        }

        public async Task<IDataResult<MessagesListDto>> GetAllByNonDeleteAndActive()
        {
            var message = await _unitOfWork.Messages.GetAllAsync(x => x.IsDelete == false && x.IsActive== true);

            if (message.Count>0)
            {

                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = message });

            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata , Kayıt Yok ", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);
            if (message != null)
            {
                message.IsDelete = true;
                await _unitOfWork.Messages.UpdateAsync(message);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata , Kayıt Bulunamadı !");
        }

        public async Task<IDataResult<MessagesDto>> Update(MessagesUpdateDto messagesUpdateDto)
        {
            if (messagesUpdateDto != null)
            {
                var message = _mapper.Map<Messages>(messagesUpdateDto);
                await _unitOfWork.Messages.AddAsync(message);
                await _unitOfWork.SaveAsync();
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });

            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata , Girdiğiniz Bilgileri Kontrol Ediniz ", null);
        }
    }
}
