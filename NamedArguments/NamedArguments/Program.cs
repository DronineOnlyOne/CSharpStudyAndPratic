using System.Numerics;

namespace NamedArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets();
            // Output : Welcome back, brave Cosmonaut.
           //           You visited 0 new planets...
          //            ...while experiencing a g-force of 4.2 g!


                /* Refer to the parameter by its name instead = {method name}({parameter name}:{value}) */
               /* Named arguments aren’t always necessary, but they can be useful when:
                                                            - a method has many optional parameters
                                                            - you want to differentiate between similar arguments */
            VisitPlanets(numberOfPlanets: 7);
            // OutPut: Welcome back, brave Cosmonaut.
           //          You visited 7 new planets...
          //           ...while experiencing a g-force of 4.2 g!

            VisitPlanets(numberOfPlanets: 2, name: "Math");
            // Output: Welcome back, brave Math.
           //         You visited 2 new planets...
          //          ...while experiencing a g-force of 4.2 g!

        }

        /* Say your method has lots of optional parameters, but you only want to specify one when you call it. */

        static void VisitPlanets(string adjective = "brave", string name = "Cosmonaut", int numberOfPlanets = 0,
         double gForce = 4.2){


            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");

        }
    }
}