using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyString _string = new EmptyString();
            StringValidator _validator1 = new StringValidator(_string);
            _validator1.CheckForEmptyString("");

            StringLength _length = new StringLength();
            StringValidator _validator2 = new StringValidator(_length);
            _validator2.CheckForLengthOfString("srivatsa");

            StartsWithString _starts = new StartsWithString();
            StringValidator _validator3 = new StringValidator(_starts);
            _validator3.CheckForStartsWithString("EXsdsiuff");
       
        }

    }
}

