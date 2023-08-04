using System.Runtime.Intrinsics.X86;

namespace MethodCallsAndInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* We activate a method’s behavior by calling it. In C# we do this by adding parentheses to the end of a method name. */

            // This prints: I'm Hungry!
            Console.WriteLine("I'm Hungry!"); // accepts one string argument

             int randomNumber = Math.Min(3, 5); // Other methods accept multiple arguments, like Math.Min(). It expects two number inputs.
            Console.WriteLine(randomNumber);

            /* You’ve probably seen built-in methods for each data type too. 
             * Every string has access to methods like IndexOf() and Substring() */
            string name = "beatrice";
            name.Substring(0, 3); // returns "bea"

            // Pratic

            string designer = "Anders Hejlsberg";

            // First, find the index of the space (" ") in the string designer and store it in a variable indexOfSpace.
            int indexOfSpace = designer.IndexOf(" ");

            //Use Substring() and the variable indexOfSpace to get the second name.Store the returned value in a variable secondName.
            string secondName = designer.Substring(indexOfSpace);

            //Print secondName to the console.
            Console.WriteLine(secondName);

        }
    }
}