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
        public DataResult(T data, ResultStatus resultStatus)
        {
            Data = data;
            ResultStatus = resultStatus;
            
        }
        public DataResult(T data, ResultStatus resultStatus, string ınfo)
        {
            Data = data;
            ResultStatus = resultStatus;
            Info = ınfo;
            
        }
        public DataResult(T data, ResultStatus resultStatus, string ınfo, Exception exception)
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
