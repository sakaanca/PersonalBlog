using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.CategoryDtos
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public Categories Categories { get; set; }
        public int Id { get; set; } // Eklenen satır
    }
}

