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
            StringLength _length = new StringLength();
            StartsWithString _starts = new StartsWithString();


            StringValidator stringValidator = new StringValidator();
            stringValidator.SetStringValidator(_string);
            stringValidator.StringValidate("");

            stringValidator.SetStringValidator(_length);
            stringValidator.StringValidate("Srivatsa M C");

            stringValidator.SetStringValidator(_starts);
            stringValidator.StringValidate("EXsefyfui");


        }

    }
}

