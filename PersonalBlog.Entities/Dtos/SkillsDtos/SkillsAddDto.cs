using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsAddDto
    {
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir !")]
        [DisplayName("Yetenek")]
        [MaxLength(40,ErrorMessage ="{0} alanı en fazla {1} karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [DisplayName("Yetenek yüzdesi")]
        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1} ile {2} karakter olmalıdır!")]
        public int PercentageValue { get; set; }
    }
}
