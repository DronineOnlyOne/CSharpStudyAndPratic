namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string input = Console.ReadLine(); // here, the user write the input or inputs in console
           // Console.WriteLine(input); // here the console read the info written in console

            Console.WriteLine(CalcSum()); // execute the program 
        }

        static int CalcSum() {

            Console.WriteLine("Please enter the first number"); // console written the message
            string inputNumb1 = Console.ReadLine(); // console read the input and save the value
            Console.WriteLine("Please enter the second number");
            string inputNumb2 = Console.ReadLine();
            int numb1 = int.Parse(inputNumb1); // the program convert string value to int value
            int numb2 = int.Parse(inputNumb2);

            int result = numb1 + numb2;
            return result;
        }
    }
}