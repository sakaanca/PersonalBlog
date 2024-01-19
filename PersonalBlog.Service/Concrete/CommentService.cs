using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.CommentsDto;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalBlog.Service.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }










        public async Task<IDataResult<CommentDto>> Add(CommentAddDto commentAddDto)
        {
            if (commentAddDto != null)
            {
                var comments = _mapper.Map<Comments>(commentAddDto);
                await _unitOfWork.Comments.AddAsync(comments);
                await _unitOfWork.SaveAsync();
                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto { Comments = comments });

            }
            return new DataResult<CommentDto>(ResultStatus.Error, "Hata , girdiğiniz bilgileri kabul ediniz .", null);
        }












        public async Task<IResult> Delete(int id)
        {
            var comment = await _unitOfWork.Comments.GetAsync(x => x.Id == id);
            if (comment != null)
            {
                comment.IsDelete = true;
                comment.ModifiedTime = DateTime.Now;
                await _unitOfWork.Comments.UpdateAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı.");
        }















        public async Task<IDataResult<CommentDto>> Get(int id)
        {
            var comment = await _unitOfWork.Comments.GetAsync(x => x.Id == id);
            if (comment != null)
            {

                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto { Comments = comment });

            }
            return new DataResult<CommentDto>(ResultStatus.Error, "Hata , Kayıt Bulunamadı .", null);
        }















        public async Task<IDataResult<CommentListDto>> GetAll()
        {
            var comment = await _unitOfWork.Comments.GetAllAsync();
            if (comment.Count > 0)
            {

                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto { Comments = comment });

            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata , Kayıt yok .", null);
        }














        public async Task<IDataResult<CommentListDto>> GetAllByNonDelete()
        {

            var comment = await _unitOfWork.Comments.GetAllAsync(x => x.IsDelete == false);
            if (comment.Count > 0)
            {

                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto { Comments = comment });

            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata , Kayıt yok .", null);
        }












        public async Task<IDataResult<CommentListDto>> GetAllByNonDeleteAndActive()
        {

            var comment = await _unitOfWork.Comments.GetAllAsync(x => x.IsDelete == false && x.IsActive == true);
            if (comment.Count > 0)
            {

                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto { Comments = comment });

            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata , Kayıt yok .", null);
        }











        public async Task<IResult> HardDelete(int id)
        {
            var comment = await _unitOfWork.Comments.GetAsync(x => x.Id == id);
            if (comment != null)
            {
                await _unitOfWork.Comments.DeleteAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);

            }
            return new Result(ResultStatus.Error, "Hata , Kayıt bulunamadı !");
        }

















        public async Task<IDataResult<CommentDto>> Update(CommentUpdateDto commentUpdateDto)
        {

            if (commentUpdateDto != null)
            {
                var comment = _mapper.Map<Comments>(commentUpdateDto);
                comment.ModifiedTime = DateTime.Now;
                await _unitOfWork.Comments.UpdateAsync(comment);
                await _unitOfWork.SaveAsync();
               


            }
            return new DataResult<CommentDto>(ResultStatus.Error, "Hata , Girdiğiniz bilgileri kontrol ediniz  .", null);
        }













    }
}
