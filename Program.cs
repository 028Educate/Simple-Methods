using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Since void can just call the method and pass in the message as a parameter
            OutputMessage("I love C# says C Shark");

            //Since message returns a string we must catch the returned value in a variable and then output
            string food = GetFavouriteFood();
            Console.WriteLine("C Shark's favourite food is : " + food);
        }

        //Method called OutputMessage that takes in a string parameter called message and outputs the message to the console.
        //Notice the method's return type is void i.e. it will not return any data from the method
        private static void OutputMessage(string message)
        {
            Console.WriteLine(message);
        }

        //Method called GetFavouriteFood that will return the Shark's favourite food e.g. tuna
        //Notice the method's return type is string i.e. it must return a string variable
        private static string GetFavouriteFood()
        {
            return "Tuna";
        }

    }
}
