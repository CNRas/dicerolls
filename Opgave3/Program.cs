using System;

namespace Opgave3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til terningeudregnerern!\n" +
                              "Skriv hvor mange terninger der skal slaas med:");
            int terninger = int.Parse(Console.ReadLine());

            Console.WriteLine(terninger);

            
            Random dice = new Random();
            
            int i = 0;
            int outcome = 0;
            while (outcome != 1 * terninger) //slår med alle terninger og kører indtil alle er 6'eree
            {
                i++;
                outcome = 0;
                for (int a = 0; a < terninger; a++)
                {
                    int res = dice.Next(1, 7);
                    outcome = res + outcome;
                    Console.Write(res+" ");
                }
                Console.WriteLine("\n");
                
            }
            Console.Write("Det tog #{0:D} kast at slå "+terninger+" 1'ere", i);
        }
    }
}
