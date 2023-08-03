namespace ConsoleAppDtp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring multiple variables at once
            int num3, num4, num5;
            // declaring a variable
            int num1;
            // assigning a value to a varibale
            num1 = 13;

            // declaring an initializing a variable in one go
            int num2 = 13;
            int sum = num1 + num2;

            // using concatination
            Console.WriteLine("num1 " + num1 + "+ num2 " + num2 + " is: " + sum);

            Console.WriteLine("-----------//------------");

            // using double datatype
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1/ d2;
            Console.WriteLine("d1 / d1 is " + dDiv);

            Console.WriteLine("-----------//------------");

            // using float datatype
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1 / f2 is " + fDiv);    // float is less precise than double. But, float uses less memory than double.

            Console.WriteLine("-----------//------------");


            Console.Read(); // used for not close the console
        }
    }
}