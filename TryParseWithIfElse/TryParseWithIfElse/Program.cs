namespace TryParseWithIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature();
        }

        static void Temperature()
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number); // if return true, the value is valid, he go to step 2


            // step 1
            if (userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature"); // if try parse return false, the value is invalid, so he return to step 1
            }

            // step 2
            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat");
            }else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine");
            }else if (numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }
        }
    }
}