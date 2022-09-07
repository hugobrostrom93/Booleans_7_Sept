using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {



        static void Main(string[] args)
        {
            
            // Övning 1 

            void AndMetod(bool myBool)
            {
                Console.WriteLine($"{myBool} And True is {myBool && true}");
                Console.WriteLine($"{myBool} And False is {myBool && false}");
            }

            AndMetod(true);
            AndMetod(false); // varför blir false && false = false??

            // Övning 2 

            void Or(bool myBooltwo)
            {
                Console.WriteLine($"{myBooltwo} or True is {myBooltwo || true}");
                Console.WriteLine($"{myBooltwo} or False is {myBooltwo || false}");
            }

            Or(true);
            Or(false);

            // Övning 3

            void Not(bool myBoolThree)
            {
                Console.WriteLine($"Not {myBoolThree} is {!myBoolThree}");
            }

            Not(true);
            Not(false);

            

            // Övning 4

            void Beslutfattande()
            {
                bool want = true; // Förstår inte vad det har för betydelse att deklarera "true" eller "false" här. Är det inte meningen att det ska räknas ut i metoden??
                bool must = true;

                Console.WriteLine("Vill du göra det?");
                want = Console.ReadLine().ToUpper() == "JA";
                Console.WriteLine("Måste du göra det?");
                must = Console.ReadLine().ToUpper() == "JA";

                bool result = want || must;
                Console.WriteLine($"Ska du göra det? Oraklet säger: {result}");
            }

            Beslutfattande();

        }






    }
}