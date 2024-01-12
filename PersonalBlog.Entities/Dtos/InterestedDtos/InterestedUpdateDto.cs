using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.InterestedDtos
{
    public class InterestedUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [Required(ErrorMessage = "{0} gerekli bir alandır !")]
        [DisplayName("İlgi Alanı")]
        [MaxLength(300, ErrorMessage = "{0} en fazla 300 karakter olmalıdr!")]
        public string Text { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır.")]
        [DisplayName("Aktif olsun  mu ?")]
        public bool IsActive { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır.")]
        [DisplayName("Silinsin mi ?")]
        public bool IsDelete { get; set; }
    }
}
