using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Results.Abstract
{
    public interface IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
