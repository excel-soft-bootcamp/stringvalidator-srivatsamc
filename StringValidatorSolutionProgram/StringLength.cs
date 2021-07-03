using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class StringLength:Ivalidate
    {
        public bool Validate(string data)
        {
            int length = data.Length;

            if (length < 8 )
            {
                return true;
            }
            return false;
        }
    }
}
