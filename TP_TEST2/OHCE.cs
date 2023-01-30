using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine(ohce.DireBonjour());

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine(ohce.Aurevoir());
            return reversedString;
        }

        public static string Palindrome(string input)
        {
            char[] inputArray = input.ToCharArray();
            Console.WriteLine(ohce.DireBonjour());

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine(ohce.Aurevoir());
            if (input == reversedString)
            {
                return ohce.BientDit();
            } else {
                return ohce.MalDit();
            }
        }

        public static string DireBonjour()
        {
            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "fr":
                    return "bonjour";
                // case "it": ...
                default:
                    return "Hello";

            }
        }
        public static string Aurevoir()
        {
            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "fr":
                    return "Au revoir";
                // case "it": ...
                default:
                    return "Goodbye";
            }
        }
        public static string BientDit()
        {
            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "fr":
                    return "Bien Dit";
                // case "it": ...
                default:
                    return "Well said";
            }
        }

        public static string MalDit()
        {
            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "fr":
                    return "bien dit";
                // case "it": ...
                default:
                    return "poorly said";
            }
        }


    }

}
