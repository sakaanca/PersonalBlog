﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.CategoryDtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Name { get; set; }
        //
        [DisplayName("Kategori İkon")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]

        public int CategoryFA { get; set; }
        //
        [DisplayName("Kategori Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir !")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1}  karakter olmalıdır!")]
        public string Description { get; set; }
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
