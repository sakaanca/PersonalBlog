using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Shared.Utilities.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus ,T data)
        {
            Data = data;
            ResultStatus = resultStatus;
            
        }
        public DataResult( ResultStatus resultStatus, string ınfo, T data)
        {
            Data = data;
            ResultStatus = resultStatus;
            Info = ınfo;
            
        }
        public DataResult( ResultStatus resultStatus, string ınfo, Exception exception, T data)
        {
            Data = data;
            ResultStatus = resultStatus;
            Info = ınfo;
            Exception = exception;
        }

            public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
