using System;

namespace PracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
// The 'Length' property tells us how many values are in the Array (4 in our example here). 
// We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine("I own a {0}", myCars[idx]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
