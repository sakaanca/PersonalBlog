using PersonalBlog.Entities.Dtos.MessagesDtos;
using PersonalBlog.Entities.Dtos.SlidersDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IMessageService
    {
        Task<IDataResult<MessagesDto>> Get(int id);
        Task<IDataResult<MessagesListDto>> GetAll();
        Task<IDataResult<MessagesListDto>> GetAllByNonDelete();
        Task<IDataResult<MessagesListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<MessagesDto>> Add(MessagesAddDto messagesAddDto);
        Task<IDataResult<MessagesDto>> Update(MessagesUpdateDto messagesUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
