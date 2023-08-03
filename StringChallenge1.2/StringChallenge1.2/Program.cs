namespace StringChallenge1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string here: ");
            //Read first input string
            string input = Console.ReadLine(); // gets the string

            Console.WriteLine("Enter a Character to search: ");

            //Read te character input to search
            char searchInput = Console.ReadLine()[0]; // gets the character written in the console

            // Gets the Index of the character from the string
            int searchIndex = input.IndexOf(searchInput); // find the index of the character
                                                          // written in "searchInput"
            // Prints the Index as a search result on console
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            // ------------------------------------------------------------------

            Console.WriteLine("     ---------------- // ----------------");

            Console.WriteLine("Enter first name: ");
            // Read the first name
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            // Read the last name
            string lastName = Console.ReadLine();

            // Concatinate the firstName and lastName variable and assign that to fullName variable
            string fullName= string.Concat(firstName," ",lastName);
            // Prints the full name on the console
            Console.WriteLine("Your full name is {0}", fullName);
        }
    }
}