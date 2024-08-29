using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Helper
{
    // TODO :: To be reWorked as resultObject
    public class BaseReponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T  Data { get; set; }
    }
}
