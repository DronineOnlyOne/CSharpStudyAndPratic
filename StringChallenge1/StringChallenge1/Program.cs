namespace StringChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Prese enter your name and press enter: ");
            myName = Console.ReadLine(); // ReadLine will read and store in variable
                                         // myName the value written in console
            string myNameUpperCase = String.Format("Upper case name: {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case name: {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed name: {0}", myName.Trim());
            string myNameSubString = String.Format("SubString value: {0}", myName.Substring(0, 4));

            Console.Write(myNameUpperCase);
            Console.Write(myNameLowerCase);
            Console.Write(myNameTrimmed);
            Console.Write(myNameSubString);
        }
    }
}