using System;
using System.Collections.Generic;
using System.Text;

namespace Week4.Utility
{
    public static class Validator
    {
        public static bool StringValidator(string val)
        {
            bool isValid = false;
            if (val != "" && val.Length >=5)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("**-------please enter a course code--------**");
            }

            return isValid;    
        } 

        public static bool IntValidator(int val)
        {
            bool isValid = false;
            if (!String.IsNullOrEmpty(val.ToString()))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("**-------please enter a number between 0 and 100--------**");
                return isValid;
            }
            if (val>= 0 && val <=100)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("**-------please enter a number between 0 and 100--------**");
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
