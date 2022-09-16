using System;
using System.Dynamic;

namespace method_with_loop_and_exercise
{
    internal class Program
    {
        
     public static void print()
        {
            for (int i = -1001; i < 1000; i++)
            {
                Console.WriteLine(i+1);
            }
        }

      public static void print3()
        {
            for (int i = 0; i < 999; i += 3)
            {
                Console.WriteLine(i+3);
            }
        }
     public static Boolean match(int num1, int num2)
            { return (num1 == num2) ? true : false; }

        public static Boolean check(int num)
            { return (num % 2 == 0) ? true : false ; }
        public static Boolean checkEvenOrOdd(int num)
        { return num >= 0? true : false; }
        public static void vote()
        {
            Console.WriteLine("what is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("YOU CAN'T VOTE");
            }
            else if (age >= 18)
            {
                Console.WriteLine("YOU CAN VOTE");
            }
        }
        public static void rangecheck()
        {
            Console.WriteLine("what is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age <= 10 && age >= -10)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public static void table(int integer)
        {
            for (int multiplier = 1;multiplier <=12; multiplier++)
            {
                Console.WriteLine("{0} x {1} = {2}",integer,multiplier,(integer * multiplier));
            }
        }
            
    
            
        static void Main(string[] args)
        {
            print();
            print3();
            match(2, 3);
            Console.WriteLine(match(2, 3));
            Console.WriteLine(check(66));
            Console.WriteLine(checkEvenOrOdd(-3));
            vote();
            rangecheck();
            table(5);

        }
    }
}
