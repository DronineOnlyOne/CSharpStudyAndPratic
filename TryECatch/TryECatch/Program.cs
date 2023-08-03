namespace TryECatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try // this block of code read the value
            {
               int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException) // if false, this block to be executed. If true, the code is valid
            // Exception is a very generic error. But we have many types of Excpetions
            {
               // in this format, we have a validation of format (datatype)
                Console.WriteLine("Format error, please enter the correct type next time");
            }
            catch (OverflowException) 
            {
                // in this format, return for us when the value is over flowed
                Console.WriteLine("Over flow, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                // in this format, return for us when the value is null
                Console.WriteLine("Argument Null, the value was empty(null)");
            }
            finally // this block execute every the try catch as executed
            // {finally} can be used when the code needs close every was executed
            {
                Console.WriteLine("Conection end");
            }

        }
    }
}