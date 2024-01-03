using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Concrete
{
    public  class AboutMe : EntityBase , IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string MyJop { get; set; }
        public string MyJopFA { get; set; }
        public DateTime BirthDate  { get; set; }
        public string MyCVPath { get; set; }

    }
}
