using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.MessagesDtos
{
    public class MessagesUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string LastName { get; set; }
        //
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1}  k arakter olmalıdır!")]
        public string EMail { get; set; }
        //
        [DisplayName("Konu")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Subject { get; set; }
        //
        [DisplayName("Mesaj")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(512, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Text { get; set; }
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
