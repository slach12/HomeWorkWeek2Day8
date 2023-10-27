namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Podaj ilość elementów ciągu fibonaciego do wyświetlenia : ");
            int fibElementsCount;
            bool isCorectCount = int.TryParse(Console.ReadLine(), out fibElementsCount);
            isCorectCount &= fibElementsCount > 0;
            if (isCorectCount)
            {
                //Przyjąłem, że ciąg definiuje się od F1 = F2 = 1
                double F1 = 1;
                double F2 = 1;
                double Fn, Fsum;

                for (int i = 1; i <= fibElementsCount; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"F{i} = {F1}");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine($"F{i} = {F2}");
                    }
                    else
                    {
                        Fn = F1 + F2;
                        Console.WriteLine($"F{i} = {Fn}");
                        F1 = F2;
                        F2 = Fn;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono nie poprawną liczbę.");
            }
        }
    }
}