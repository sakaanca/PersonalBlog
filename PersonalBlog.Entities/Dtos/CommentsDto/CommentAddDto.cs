using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.CommentsDto
{
    public class CommentAddDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string LastName { get; set; }
        //
        [DisplayName("Yorum")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(512, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]

        public string Text { get; set; }
        //
        [DisplayName("Makale")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        
        public int ArticIeId { get; set; }
    }
}
