namespace methodOutPut
{
    internal class Program


    {
        static void Main(string[] args)
        {
            //  ------------------------------  return in method  ------------------------------ 
            /* if a method returns an integer, its return type must be int; if it returns text, it must be string, and so on. 
             * If the method returns nothing, use void. */
            Console.WriteLine(DecoratePlanet("Jupiter")); // i call the WriteLine here

            //  ------------------------------ Error in method  ------------------------------ 
            /* If a method returns a type different from its stated return type, it will throw an error. Here are some common errors you may see */
            //This error means you must state a return type before the method name
            // error CS1520: Method must have a return type

            //This error means that your method doesn’t return a value, when it should:
            //error CS0161: [MethodName]: not all code paths return a value

            /* In some cases, this error means that your method returns a string when it should be an int 
             * (this one can be caused by a lot of things outside of methods): */
            //error CS0029: Cannot implicitly convert type 'string' to 'int'

            Console.WriteLine(DecoratePlanet0("Mars"));
            Console.WriteLine("Is Pluto really a dwarf...?");
            Console.WriteLine(IsPlutoADwarf());
            Console.WriteLine("Then how many planets are there in the galaxy...?");
            Console.WriteLine(CountThePlanets("8"));

            //   ------------------------------ Out parameter in method  ------------------------------ 
            /* A method can only return one value, but sometimes you need to output two pieces of information.
             * Calling a method that uses an out parameter is one way to return multiple values. */
            OutParameter();

            //   ------------------------------ Using Out  ------------------------------ 
            string statement = "GARRRR";
            string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur);

            static string Whisper(string phrase, out bool wasWhisperCalled) // The out parameter must have the out keyword and its expected type
            {
                wasWhisperCalled = true; // The out parameter must be set to a value before the method ends
                return phrase.ToLower();
            }
        }

        //  ------------------------------  return in method  ------------------------------ 
        static string DecoratePlanet(string planet)
        {
            return $"*.*.* Welcome to {planet} *.*.*"; // I don't need to call the WriteLine method here
        }

        //  ------------------------------ Error in method  ------------------------------ 
        // wrong way (with error)

        /*
          static DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        static bool IsPlutoADwarf()
        {
            bool answer = true;
        }

        static int CountThePlanets()
        {
            return "8 planets, usually";
        }
        */

        // right way (without error)
        static string DecoratePlanet0(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        static bool IsPlutoADwarf()
        {
            bool answer = true;
            return answer;
        }

        static string CountThePlanets(string count)
        {
            return $"{count} planets, usually";
        }

        //   ------------------------------ Out parameter in method  ------------------------------ 

        static void OutParameter()
        {
            string ageAsString = "102";
            string nameAsString = "Granny";

            int ageAsInt;  //should be used as the out argument
            bool outcome; // should capture the returned value

            outcome = Int32.TryParse(ageAsString, out ageAsInt);

            Console.WriteLine(ageAsInt); // and the ageAsInt capture the integer value
            Console.WriteLine(outcome); // outcome capture the boolean value

            int nameAsInt;
            bool outcome2;

            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

            Console.WriteLine(nameAsInt);
            Console.WriteLine(outcome2);

        }
    }
}