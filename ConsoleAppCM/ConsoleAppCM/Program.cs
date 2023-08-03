namespace ConsoleAppCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string and press enter: "); // receive the value inserted
            string readInput = Console.ReadLine(); // read the write line in console
            Console.WriteLine("You have {0}", readInput); // return the typed value

            Console.Write("Enter any key of your keyboard and press enter: ");
            int asciiValue = Console.Read(); // read and return the value of key in console
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
        }
    }
}