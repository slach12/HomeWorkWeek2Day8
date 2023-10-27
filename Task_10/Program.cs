namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10");
            Console.WriteLine("Podaj pierwszą liczbę (powinna być większa od 0): ");
            int number1;
            bool isNumber1Correct = int.TryParse(Console.ReadLine(), out number1);
            isNumber1Correct &= number1 > 0;
            Console.WriteLine("Podaj drugą liczbę (powinna być większa od 0): ");
            int number2;
            bool isNumber2Correct = int.TryParse(Console.ReadLine(), out number2);
            isNumber2Correct &= number2 > 0;
            //Obliczenia NWW
            if (isNumber1Correct && isNumber2Correct)
            {
                int liczbaA, liczbaB;
                liczbaA = number1;
                liczbaB = number2;
                while (liczbaA != liczbaB)
                {
                    if (liczbaA > liczbaB)
                    {
                        liczbaA = liczbaA - liczbaB;
                    }
                    else
                    {
                        liczbaB = liczbaB - liczbaA;
                    }
                }
                Console.WriteLine($"NWW({number1},{number2})  = {number1 / liczbaA * number2}");
            }
            else
            {
                if (!isNumber1Correct)
                {
                    Console.WriteLine("Pierwsza liczba jest nie prawidłowa");
                }
                if (!isNumber2Correct)
                {
                    Console.WriteLine("Druga liczba jest nie prawidłowa");
                }
            }

        }
    }
}