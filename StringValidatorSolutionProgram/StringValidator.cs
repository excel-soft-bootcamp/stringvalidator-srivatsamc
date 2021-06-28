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

        public StringValidator(Ivalidate data)
        {
            this._validate = data;
        }

        public void CheckForEmptyString(string userString)
        {
           bool emptyStringResult= _validate.Validate(userString);
           Console.WriteLine("The string given to check empty is :"+emptyStringResult);
        }

        public void CheckForLengthOfString(string userGivenString)
        {
            bool lengthOfStringResult = _validate.Validate(userGivenString);
            Console.WriteLine("The string given to check length condition is :" + lengthOfStringResult);
        }

        public void CheckForStartsWithString(string userStringGiven)
        {
            bool startsWithResult = _validate.Validate(userStringGiven);
            Console.WriteLine("The string given to check starts with is:" + startsWithResult);
        }
     
    }
}
