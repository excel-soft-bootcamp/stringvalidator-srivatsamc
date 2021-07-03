using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class StringValidator
    {
        Ivalidate _validate;

        public void SetStringValidator(Ivalidate data)
        {
            this._validate = data;
        }

        public void StringValidate(string dataString)
        {
            bool returnValue= this._validate.Validate(dataString);
            Console.WriteLine(returnValue);

        }

       
     
    }
}
