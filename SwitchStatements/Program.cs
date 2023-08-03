namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch(age)
            {
                case 15: // this case compared with varibale age
                    Console.WriteLine("Too yong to party in the club!"); // if age < case 15, this CW starts
                    break; // i need write the "break" for the switch works. Because, if this case to be true, the break stops
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default: // is called every the others is true
                    Console.WriteLine("how old are you then?"); // works like else for the if else statements
                    break;

            }
        }
    }
}