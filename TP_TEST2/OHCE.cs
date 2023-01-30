using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class ohce
    {

        public static string revstring(string input)
        {
            char[] inputArray = input.ToCharArray();


            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine("Au revoir");
            return reversedString;
        }

        public static string Palindrome(string input)
        {
            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine("Au revoir");
            if (input == reversedString)
            {
                return "bien dit";
            } else {
                return "Mal dit";
            }
        }


    }
}
