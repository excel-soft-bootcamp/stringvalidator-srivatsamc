using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class StartsWithString:Ivalidate
    {
        public bool Validate(string data)
        {
            if( data.StartsWith("EX"))
            {
                return true;   
            
            }
            return false;
            
        }

    }
}
