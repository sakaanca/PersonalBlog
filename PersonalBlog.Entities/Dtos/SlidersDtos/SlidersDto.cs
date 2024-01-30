using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SlidersDtos
{
    public class SlidersDto
    {
        public int Id { get; set; }

        public HomePageSliders Sliders { get; set; }
    }
}
