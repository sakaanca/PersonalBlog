using PersonalBlog.Entities.Dtos.ArticlesDtos;
using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Concrete
{
    public  class Articles : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public int ViewsCount { get; set; }=0;// Başlangıç değeri 0 olarak atanmıştır.
        public string SeoTags { get; set; }
        public string SeoDecription { get; set; }
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public ICollection<Comments> Comments { get; set; }

        public static implicit operator Articles(ArticleAddDto v)
        {
            throw new NotImplementedException();
        }
    }
}
