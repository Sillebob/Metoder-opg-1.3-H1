using System;

namespace Metoder_opg_1._3_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	Indtast navn og alder i konsollen og: 
                  -	Hvis alder < 3 skal I udskrive ” Camilla, du må gå med ble”
                  -	Hvis alderen er mellem 3 og 15 skal I udskrive ” Camilla, du må ingenting” 
                  -	Hvis alderen er mellem 15 og 18 (ikke inklusive) skal I udskrive ” Camilla, du må drikke” 
                  -	Hvis alderen er 18 eller derover, skal I udskrive ” Camilla, du må stemme og køre bil”*/
           
            String navn = GetName("Indtast dit navn"); //Metodekald til at få navn
                
            int alder = GetAge("Indtast din alder"); //Metodekald til at få alder

            AlderTest(navn, alder); // Metodekald til at tjekke alder og udskrive besked

            Console.ReadKey();
        }
        //Opretter metode til at få brugerens navn
        public static string GetName(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine(); /*returnerer brugerens indtastning, her skal der ikke konverteres 
                                         da den erklærede variabel er en string*/
        }
        //Opretter metode for at få brugerens alder
        public static int GetAge(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
       //Opretter metode til at tjekke alder og udskrive besked
        public static void AlderTest(string navn, int alder)//uden returværdi med skal have to variabler med ved metodekaldet i Main
        {
            if (alder < 3)
            {
                Console.WriteLine("{0}, du må gå med ble", navn); //hvis alderen er mindre end 3 udføres denne linje kode
            }
            else if (alder <= 15)
            {
                Console.WriteLine("{0} du må ingenting", navn);
            }
            else if (alder < 18) //behøver ikke sætte grænsen til 3 da der allerede er tjekket for mindre end 3 ovenfor
            {
                Console.WriteLine("{0}, du må drikke", navn);
            }
            else if (alder >= 18)
            {
                Console.WriteLine("{0}, du må stemme og køre bil", navn);
            }

        }
    }
}