using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Concrete
{
    public  class SocialMediaAccounts : EntityBase, IEntity
    {
        public string Account { get; set; }
        public string AccountFA { get; set; }
        public string AccountUrl { get; set; }
    }
}
