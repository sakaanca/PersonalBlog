﻿using PersonalBlog.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Shared.Utilities.Abstract
{
    public  interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Info { get; }
        public Exception Exception { get; }// Hataları yönetmek için kullanırız.

    }
}
