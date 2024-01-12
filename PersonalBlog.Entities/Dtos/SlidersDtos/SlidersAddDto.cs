using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SlidersDtos
{
    public class SlidersAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir!")]
        [MaxLength(40,ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ShortContent { get; set; }
        //
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        
        public string Content { get; set; }
    }
}
