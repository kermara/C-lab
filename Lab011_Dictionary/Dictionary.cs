using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab011_Dictionary
{
    class Dictionary
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        public Dictionary()
        {

        }

        public void Translate()
        {
            myDictionary.Add("maanantai", "Monday");
            myDictionary.Add("tiistai", "Tuesday");
            myDictionary.Add("keskiviikko", "Wednesday");
            myDictionary.Add("torstai", "Thursday");
            myDictionary.Add("perjantai", "Friday");
            myDictionary.Add("lauantai", "Saturday");
            myDictionary.Add("sunnuntai", "Sunday");

            Console.WriteLine("Minkä viikonpäivän haluat kääntää englanniksi? ");
            string input = Console.ReadLine();
            input = input.ToLower();
            //string output = in myDictionary.Keys;
                Console.WriteLine(input + " on englanniksi: " + myDictionary[input]);
         }
        
    }
}
