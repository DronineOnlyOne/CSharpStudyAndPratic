namespace ConstantsC
{
    // Contants are immtable values wich are known
    // at compile time and do not change for the lifre of the program

    internal class Program
    {
        // constants as fields
        const double PI = 3.141592265359;
        const int weeks = 52, month = 12;
        // Create a constant of type string with your birthday as its value
        const string birthday = "05/09/2002";
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
        }
    }
}