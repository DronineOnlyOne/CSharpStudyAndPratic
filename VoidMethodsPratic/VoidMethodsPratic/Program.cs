namespace VoidMethodsPratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething(); // 2. beccause in this main method, him is a static method too
            WriteSomethingSpecific("I am an argument and am called from a method"); // 3. and here, i write
                                                                                    // the message of the variable declared
            Console.WriteLine(Add(15, 54));
            Console.WriteLine(Add(25,2) * Add(30,1)); // in this way, i execute the method,
                                                      // and multiply the two values of two methods called.
                                                      // But, i don't need make like that.
            Console.WriteLine(Div(25,2));
        }

        // Methods without return
        // acess modifier (static) return type method name (paramter1, paramter2)
        public static void WriteSomething() //1.  i need declare type of method. Like "static"
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText) // 1. here i declare a variable
        {
            Console.WriteLine(myText); // 2. the variable is called here
        }
        // Methods with return
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1,double num2) { 
        
            return num1 / num2;
        
        }
    }
}