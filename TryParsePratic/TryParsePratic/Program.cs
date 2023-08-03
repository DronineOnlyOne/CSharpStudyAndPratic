namespace TryParsePratic
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            IntParse();
            FloatParse();
            FailedParse();
        }

        // try parse with INTEGER
        static void IntParse()
        {
            string numberAsString = "128";
            int parsedValue;
            bool sucess = int.TryParse(numberAsString, out parsedValue);
            if (sucess)
            {
                Console.WriteLine("Parsing sucessufl - number is " + parsedValue);

            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }

        // try parse with FLOAT
        static void FloatParse()
        {
            string numberAsString = "12,8";
            float parsedValue;

            bool sucess = float.TryParse(numberAsString, out parsedValue);

            if (sucess)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            }
            else {
                Console.WriteLine("Parsing failed");
             }

        }


        // we have so many types of {TRY PARSE}

        // try parse failed

        static void FailedParse() // can works with many types of values
        {

            string age = "12a";
            int parsedValue;
            bool sucess = int.TryParse(age, out parsedValue);
            if (sucess)
            {
                Console.WriteLine("Parsin sucessful - number is ", parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }


    }
}