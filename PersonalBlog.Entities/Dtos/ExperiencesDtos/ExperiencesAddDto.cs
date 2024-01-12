using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.ExperiencesDtos
{
    public class ExperiencesAddDto
    {
        
        [DisplayName("Deneyim Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Title { get; set; }
        //
        
        [DisplayName("Deneyim Yeri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string WorkPlace { get; set; }
        //
        [DisplayName("Deneyim Süresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Duration { get; set; }

        //
        [DisplayName("Deneyim Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Description { get; set; }
    }
}
