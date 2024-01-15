using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.ArticlesDtos
{
    public class ArticleAddDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Makale Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string ShortContent { get; set; }
        //
        [DisplayName("Makale İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        
        public string Content { get; set; }
        //
        [DisplayName("Makale Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Thumbnail { get; set; }
        //
        
        [DisplayName("SEO Anahtar")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string SeoTags { get; set; }
        //
        [DisplayName("TSEO Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string SeoDecription { get; set; }
        //
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
       
        public int CategoryId { get; set; }
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
