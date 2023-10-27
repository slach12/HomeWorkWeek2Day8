namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 9");
            Console.WriteLine("Podaj liczbę do zamiany na postać binarną : ");
            int liczba;
            bool isCorretLiczba = int.TryParse(Console.ReadLine(), out liczba);
            if (isCorretLiczba)
            {
                Console.Write($"Liczba {liczba} w postaci binarnje jest równa : ");
                string binaryNumber = "";
                while (liczba > 0)
                {
                    if (liczba % 2 == 0)
                    {
                        binaryNumber = "0" + binaryNumber;
                    }
                    else
                    {
                        binaryNumber = "1" + binaryNumber;
                    }
                    liczba = (liczba / 2);
                }
                Console.WriteLine(binaryNumber);
            }
            else
            {
                Console.WriteLine("Wprowadzona liczba nie jest prawidłowa.");
            }
        }
    }
}