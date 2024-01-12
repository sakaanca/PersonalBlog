using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Yetenek")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]

        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Yetenek yüzdesi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]

        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1} ile {2} karakter olmalıdır!")]
        public int PercentageValue { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır.")]
        [DisplayName("Aktif Olsun  mu ?")]
        public bool IsActive { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır.")]
        [DisplayName("Silinsin mi ?")]
        public bool IsDelete { get; set; }
    }
}
