using System;

namespace Practice_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Hello, my name is Hunter.");
            Console.WriteLine();

            //Question 2
            int a = 16;
            int b = 4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("The sum of those 2 numbers is:");
            Console.WriteLine(a+b);
            Console.WriteLine();

            //Question 3
            Console.WriteLine("The difference in those two numbers is:");
            Console.WriteLine(a-b);
            Console.WriteLine();

            //Question 4
            a ++;
            Console.WriteLine("The first number plus 1 is:");
            Console.WriteLine(a);
            b --;
            Console.WriteLine("The second number minus one is:");
            Console.WriteLine(b);
            Console.WriteLine();

            //Question 5
            string stringVariable = "This is a string";
            int intVariable = 15;
            char charVariable = 'X';
            bool boolVariable = false;
            double doubleVariable = 7.77;

            //Question 6
            Console.WriteLine("Please enter a whole number:");
            int ifStatmentVariable = Convert.ToInt32(Console.ReadLine());

            if (ifStatmentVariable > 20)
            {
                Console.WriteLine("That number is greater than 20.");
            }
            else if (ifStatmentVariable < 20)
            {
                Console.WriteLine("That number is less than 20.");
            }
            else
            {
                Console.WriteLine("That number is equal to 20.");
            }
            Console.WriteLine();

            //Question 7
            int c = 10;
            int d = 2;
            int e = 10;
            string[] names = { "Smith", "Piper", "Adam", "Hunter", "Bailey" };

            Console.WriteLine("These are the students in Truecoders:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("Please say yes and press enter");
            string userInput = Console.ReadLine();
            while (userInput != "yes")
            {
                Console.WriteLine("Please say yes and press enter");
                userInput = Console.ReadLine();
            }
            Console.WriteLine();

            do
            {
                Console.WriteLine("We start with the number 10.");
                Console.WriteLine(c);

            } while (c < 5);
            Console.WriteLine();

            Console.WriteLine("Counting down from there:");
            for (int f = 1; f <= 10; f++)
            {
                c = c - 1;
                Console.WriteLine(c);
            }



        }
    }
}
