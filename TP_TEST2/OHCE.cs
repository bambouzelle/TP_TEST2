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
            Console.WriteLine(ohce.DireBonjourperiodejourne());

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine(ohce.Aurevoirperiodejournee());
            return reversedString;
        }

        public static string Palindrome(string input)
        {
            char[] inputArray = input.ToCharArray();
            Console.WriteLine(ohce.DireBonjourperiodejourne());

            Array.Reverse(inputArray);
            string reversedString = new string(inputArray);

            Console.WriteLine(ohce.Aurevoirperiodejournee());
            if (input == reversedString)
            {
                return ohce.BientDit();
            } else {
                return ohce.MalDit();
            }
        }

        public static string DireBonjourperiodejourne()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan debutmatin = new TimeSpan(06, 0, 0);
            TimeSpan finmatin = new TimeSpan(11, 59, 59);
            TimeSpan debutapremidi = new TimeSpan(12, 0, 0);
            TimeSpan finapremidi = new TimeSpan(17, 59, 59);
            TimeSpan debutsoiree = new TimeSpan(18, 0, 0);
            TimeSpan finsoiree = new TimeSpan(20, 59, 59);

            if (currentTime.TimeOfDay >= debutmatin && finmatin >= currentTime.TimeOfDay)
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "bonjour";
                    // case "it": ...
                    default:
                        return "Good morning";
                }
            }
            else if (currentTime.TimeOfDay >= debutapremidi && finapremidi >= currentTime.TimeOfDay)
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "Bon après-midi";
                    // case "it": ...
                    default:
                        return "Good afternoon";
                }
            }
            else if (currentTime.TimeOfDay >= debutsoiree && finsoiree >= currentTime.TimeOfDay)
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "Bonsoir";
                    // case "it": ...
                    default:
                        return "Good evening";
                }
            }
            else
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "Bonne nuit";
                    // case "it": ...
                    default:
                        return "Good night";
                }
            }

        }

        public static string Aurevoirperiodejournee()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan debutmatin = new TimeSpan(06, 0, 0);
            TimeSpan finmatin = new TimeSpan(11, 59, 59);
            TimeSpan debutapremidi = new TimeSpan(12, 0, 0);
            TimeSpan finapremidi = new TimeSpan(17, 59, 59);
            TimeSpan debutsoiree = new TimeSpan(18, 0, 0);
            TimeSpan finsoiree = new TimeSpan(20, 59, 59);

            if (currentTime.TimeOfDay >= debutmatin && finmatin >= currentTime.TimeOfDay)
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "bonne matinee";
                    // case "it": ...
                    default:
                        return "Goodbye";
                }
            }
            else if (currentTime.TimeOfDay >= debutapremidi && finapremidi >= currentTime.TimeOfDay)
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
            else if (currentTime.TimeOfDay >= debutsoiree && finsoiree >= currentTime.TimeOfDay)
            {
                switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
                {
                    case "fr":
                        return "Bonne soiree";
                    // case "it": ...
                    default:
                        return "Goodbye";
                }
            }
            else
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
                    return "Mal dit";
                // case "it": ...
                default:
                    return "poorly said";
            }
        }


    }

}
