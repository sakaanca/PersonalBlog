using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.AdminDtos
{
    public class AdminUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string EMail { get; set; }
        //
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Password { get; set; }
        //
        [DisplayName("Güvenlik Sorusu")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string SecurityQuestion { get; set; }
        //
        [DisplayName("Güvenlik Sorusu Cevabı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string SQAnswer { get; set; }
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
