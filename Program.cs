public class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 42;
        int input;
        Console.WriteLine("Guess the secret number:");
        input = Convert.ToInt32(Console.ReadLine());

        if(input == secretNumber) 
        {
            Console.WriteLine("CORRECT!");
        } 
        else
        {
            Console.WriteLine("Sorry, incorrect guess!");
        }
    }
}