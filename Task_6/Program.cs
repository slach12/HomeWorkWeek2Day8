namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6");
            double suma = 0;
            for (int i = 1; i <= 20; i++)
            {
                suma += 1 / (double)i;
            }
            Console.WriteLine($"Szukana suma wynosi {suma}");
        }
    }
}