using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Concrete
{
    public  class Education : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string School { get; set; }
        public string Duration { get; set; }
        public string Avarge { get; set; }
        public string Description { get; set; }

    }
}
