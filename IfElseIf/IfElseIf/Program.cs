namespace IfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);
            
            if (numTemp < 20) // if false the next condition is played
            {
                Console.WriteLine("Take the coat");

            }else if (numTemp == 20)
            {
                Console.WriteLine("It's 20 degrees C°");

            }else
            {
                Console.WriteLine("Cozy & warm!"); 

            }
        }
    }
}