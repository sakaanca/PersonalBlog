using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.AboutMeDtos
{
    public class AboutMeUpdateDto
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
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string LastName { get; set; }
        //
        [DisplayName("Profil Fotoğrafı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string ImagePath { get; set; }
        //
        [DisplayName("Meslek")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string MyJop { get; set; }
        //
        [DisplayName("Meslek İkon")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string MyJopFA { get; set; }
        //
        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]

        public DateTime BirthDate { get; set; }
        //
        [DisplayName("Özgeçmiş")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string MyCVPath { get; set; }
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
