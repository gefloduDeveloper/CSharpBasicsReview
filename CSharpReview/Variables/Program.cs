using System;

namespace Basics
{
    class Program
    {
        /*
         * This simple program is created looking to review the basics for C#
         */

        static void Main(string[] args)
        {
            //Variables could be created inside any function(local) or for the whole program (global)
            //Variables could be numeric (int, double, float, etc.), text(char, string, etc.), boolean, etc.
            int namesLenght = 3;

            //Arrays are collections of variables, they have to have the same type
            string[] names = new string[namesLenght];

            //function cretaed with no return (void type)
            getNames(names);

            //functions with return can be used directly on a varaible creation
            string concatNames = singleLineNames(names);

            //sentence used to print text on the console
            Console.WriteLine(concatNames);
        }

        //function with return type is always expected to have a value out of the excecution
        private static string singleLineNames(string[] names)
        {
            string result = "";
            int index = 0;
            
            //while loops are usually used to evaluate different conditions before its iterative execution
            //a variation for this kind of loops is the "do-while" which guarantees at least one execution of the sentences inside
            while(index < names.Length && names[index] != null)
            {
                //if sentences help us to decide which way to preceed given specific conditions based on varaibles values
                if(result == "")
                {
                    result = names[index];
                }
                else
                {
                    result = result + " - " + names[index]; 
                }
                index++;
            }
            return result;
        }

        //function with void type means there is no return value out of it
        private static void getNames(string[] names)
        {
            //for sentences usually are used to do an action for specific times, however the validation sentence can have any boolean result validation sentence
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(string.Format("Insert user name ({0} out of {1})", i + 1, names.Length));

                //sentence used to get text from the console
                names[i] = Console.ReadLine();
            }
        }
    }
}
