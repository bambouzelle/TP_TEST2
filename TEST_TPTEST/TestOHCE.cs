using OHCE;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TEST_OHCE
{
    public class Test_ohce
    {
        [Theory]
        [InlineData("fr", "06:00:00", "bonjour")]       // on test toutes les possibilité différente 
        [InlineData("en", "06:00:00", "Good morning")]  // car le résultat dépend de l'heure locale de notre Ordinateur
        [InlineData("fr", "12:00:00", "Bon après-midi")]// et pour voir si il ne retourne pas un faux positif
        [InlineData("en", "12:00:00", "Good afternoon")]
        [InlineData("fr", "18:00:00", "Bonsoir")]
        [InlineData("en", "18:00:00", "Good evening")]
        [InlineData("fr", "23:59:59", "Bonne nuit")]
        [InlineData("en", "23:59:59", "Good night")]

        public void TestDireBonjourperiodejourne(string lang, string time, string expected)
        {
            DateTime currentTime = DateTime.Parse(time);

            string result = ohce.DireBonjourperiodejourne();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("fr", "06:00:00", "bonne matinee")] // dans ce cas on peut avoir 2 réussite car il renvoie tout les au revoir       
        [InlineData("en", "06:00:00", "Goodbye")]  
        [InlineData("fr", "12:00:00", "Au revoir")]
        [InlineData("en", "12:00:00", "Goodbye")]
        [InlineData("fr", "18:00:00", "Bonne soiree")]  
        [InlineData("en", "18:00:00", "Goodbye")]
        [InlineData("fr", "23:59:59", "Au revoir")]
        [InlineData("en", "23:59:59", "Goodbye")]

        public void TestAurevoirperiodejournee(string lang, string time, string expected)
        {
            DateTime currentTime = DateTime.Parse(time);

            string result = ohce.Aurevoirperiodejournee();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("fr", "Bien Dit")]
        [InlineData("en", "Well said")]
        
        public void TestBientDit(string lang, string expected) 
        {
            var result = ohce.BientDit();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("fr", "Mal dit")]
        [InlineData("en", "poorly said")]

        public void testAurevoir(string lang, string expected) 
        {
            var result = ohce.MalDit();
            Assert.Equal(expected, result);
        }



    }
}
