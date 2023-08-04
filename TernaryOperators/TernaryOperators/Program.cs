namespace TernaryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary operators can also be chained, like else if statements
            string color = "blue"; // The expression starts with the Boolean expressions (color == "blue")
            string result = (color == "blue") ? "blue" : "NOT blue"; /* followed by the ternary operator ?, 
                                                                      * then the two possible outcomes, separated by a colon :. 
                                                                      * The first outcome, "blue" will be saved to result if the 
                                                                      * Boolean expression evaluates to true */

            Console.WriteLine(result);

            /* Pratic */

            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}