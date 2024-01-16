using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.Accounts
{
    public class AccountsUpdateDto
    {
        [Required]
        public int Id { get; set; } 
        //
        [DisplayName("Sosyal Medya Hesabı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla 30 karakter uzunluğunda olmalıdr !")]
        public string Account { get; set; }
        //
        [DisplayName("Sosyal Medya Hesabı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla 30 karakter uzunluğunda olmalıdr !")]
        public string AccountFA { get; set; }
        //
        [DisplayName("Sosyal Medya Hesabı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla 30 karakter uzunluğunda olmalıdr !")]
        public string AccountUrl { get; set; }
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
