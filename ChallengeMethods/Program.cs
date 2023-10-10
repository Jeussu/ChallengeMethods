using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Alice";
            string friend3 = "Bob";

            GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }
        // access modifier (static) return type method name(parameter1, parameter2)

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
            Console.WriteLine("Hi " + friendName2 + " , my friend!");
            Console.WriteLine("Hi " + friendName3 + " , my friend!");
        }
    }
}
