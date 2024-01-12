using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.Accounts
{
    public class AccountListDto
    {
        public IList<SocialMediaAccounts> SocialMediaAccounts { get; set; }
    }
}
