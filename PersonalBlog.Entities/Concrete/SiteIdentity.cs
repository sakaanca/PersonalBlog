using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Concrete
{
    public  class SiteIdentity : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Desciption { get; set; }
        public string LogoText { get; set; }
        public string LogoFA { get; set; }

    }
}
