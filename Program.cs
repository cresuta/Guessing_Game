public class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 42;
        int guessCount = 0;
        int input;


        while (guessCount < 4)
        {
            Console.WriteLine("Guess the secret number:");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == secretNumber)
            {
                Console.WriteLine("\nCORRECT!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, incorrect guess!");
                Console.WriteLine($"\nPrevious guess ({input})");
                guessCount++;

            }

        }
    }
}