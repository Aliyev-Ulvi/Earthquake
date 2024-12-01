using Core.Helpers.Results.Concrete.BaseResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string message) : base(default, false, message)
        {
            
        }

        public ErrorDataResult() : base(default, false)
        {
            
        }
    }
}
