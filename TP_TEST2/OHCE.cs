using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class ohce
    {

        public string revstring(string input)
        {
            char[] inputArray = input.ToCharArray();

            Console.WriteLine("Bonjour");
            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine(reversedString);
            Console.WriteLine("Au revoir");
            return reversedString;
        }

        public string Palindrome(string input)
        {
            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            if (input == reversedString)
            {
                Console.WriteLine("bien dit");
            }

            return reversedString;
        }


    }
}
