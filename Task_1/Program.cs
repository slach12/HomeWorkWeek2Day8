namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int primeNumbers = 0;
            bool isPrimeNumber;
            Console.WriteLine("Task 1");
            for (int i = 2; i <= 100; i++)
            {
                isPrimeNumber = true;
                for (int j = i - 1; j > 2; j--)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    primeNumbers++;
                }
            }
            Console.WriteLine($"W przdziale od 0 do 100 jest {primeNumbers} liczb pierwszych.");
            //Czy ten przedział jest zamknięty czy otwarty tj czy 0 i 100 uwzględniamy
            //0 i 1 nie są ani liczbami pierwszymi ani złożonymi
        }
    }
}