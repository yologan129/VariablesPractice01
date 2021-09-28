using System;

namespace VariablesPractice01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Logan";
            int age = 21;
            char middleI = 'W';
            bool isAlive = true;
            double height = 5.9;
            decimal amount = 100.00m;
            Console.WriteLine($"hey my name is {firstName}. I am {age} years old. My middle name starts with a {middleI}." +
                $"It is {isAlive} that I am alive today. I am {height} in height. I want ${amount}.");


        }
    }
}
