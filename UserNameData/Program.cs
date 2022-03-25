using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab eesnime esimest tahte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnime");
            string userName = Console.ReadLine();

            GetUsernameData(userName);

        }

        public static void GetUsernameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");



            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }




    }
}
