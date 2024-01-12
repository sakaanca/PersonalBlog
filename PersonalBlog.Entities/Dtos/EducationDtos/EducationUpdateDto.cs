using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.EducationDtos
{
    public class EducationUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Eğitim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Okul")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string School { get; set; }
        //
        [DisplayName("Eğitim Süresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(255, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Duration { get; set; }
        //
        [DisplayName("Ortalama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(55, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Avarge { get; set; }
        //
        [DisplayName("Eğitim Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Description { get; set; }
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
