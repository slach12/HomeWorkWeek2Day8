namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");
            int i = 0;
            int evenNumbersCount = 0;
            do
            {
                if (i % 2 == 0)
                {
                    evenNumbersCount++;
                }
                i++;
            } while (i <= 1000);
            Console.WriteLine($" W przedziale od 0 do 1000 jest {evenNumbersCount} parzystych liczb.");
        }
    }
}