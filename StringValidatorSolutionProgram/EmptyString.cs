using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class EmptyString:Ivalidate
    {
        public bool Validate(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return true;
            }
            return false;
        }
    }
}
