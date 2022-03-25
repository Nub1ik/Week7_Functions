using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta esimest arvu");
            int userNuberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine arv");
            int userNuberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+', '-', '*' voi '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNuberOne, userNuberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNuberOne, userNuberTwo);
                    break;
                case '*':
                    MultiplyTwoNubers(userNuberOne, userNuberTwo);
                    break;
                case '-':
                    subtractTwoNubers(userNuberOne, userNuberTwo);
                    break;
                default:
                    Console.WriteLine("Kena paeva");
                    break;

            }

        }

        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);

        }

        public static void MultiplyTwoNubers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        public static void subtractTwoNubers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
