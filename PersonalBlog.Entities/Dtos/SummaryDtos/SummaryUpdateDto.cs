using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SummaryDtos
{
    public class SummaryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [Required(ErrorMessage ="{0} alanı zorunlu bir alandır.")]
        [DisplayName("Özet Bilgsi")]
        [MinLength(200,ErrorMessage ="{0} alanı en az {1} karakter olmalıdır !")]
        public string Content { get; set; }
        //
        [Required(ErrorMessage ="{0} alanı zorunlu bir alandır.")]
        [DisplayName("Aktif Olsun  mu ?")]
        public bool IsActive { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır.")]
        [DisplayName("Silinsin mi ?")]
        public bool IsDelete { get; set; }
        //
    }
}
