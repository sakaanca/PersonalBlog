using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SiteIdentityDtos
{
    public class SiteIdentityUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Site Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Site Anahtar Kelimeler")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Keywords { get; set; }
        //
        [DisplayName("Site Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Desciption { get; set; }
        //
        [DisplayName("Logo Yazısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string LogoText { get; set; }
        //
        [DisplayName("Logo İkonu")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string LogoFA { get; set; }
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
