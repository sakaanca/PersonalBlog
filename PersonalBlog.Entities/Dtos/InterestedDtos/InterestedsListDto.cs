using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.InterestedDtos
{
    public class InterestedsListDto
    {
        public IList<Interesteds> Interesteds { get; set; }
    }
}
