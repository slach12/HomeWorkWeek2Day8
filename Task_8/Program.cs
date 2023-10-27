namespace Task_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 8");
            Console.WriteLine("Podaj tekst do odwrócenia:");
            String aText = Console.ReadLine();
            for (int i = aText.Length - 1; i >= 0; i--)
            {
                Console.Write(aText[i]);
            }
        }
    }
}