using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.MessagesDtos
{
    public class MessagesListDto
    {
        public IList<Messages> Messages { get; set; }
    }
}
