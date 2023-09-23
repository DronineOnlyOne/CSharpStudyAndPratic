using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            /* when we say that the methods are “different”,
             * we are really talking about their method signatures, which is the method’s name and parameter types in order */
            NamePets("Laika", "Albert");          /* Output: Your pets Laika and Albert will be joining your voyage across space! */ 
            NamePets("Mango", "Puddy", "Bucket"); /* Output: Your pets Mango, Puddy and Bucket will be joining your voyage across space! */
            NamePets(); /* Output: Aw, you have no spacefaring pets :( */
        }

        /* Though they have the same name, the overloads are different because they have either (i) 
         * different parameter types or (ii) different number of parameters */
        /* This is useful if you want the same method to have different behavior based on its inputs. */
        static void NamePets(string pet1, string pet2)
        {
            Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
        }

        static void NamePets(string pet1, string pet2, string pet3)
        {
            Console.WriteLine($"Your pets {pet1}, {pet2} and {pet3} will be joining your voyage across space!");
        }

        static void NamePets()
        {
            Console.WriteLine($"Aw, you have no spacefaring pets :(");
        }
    }
}
