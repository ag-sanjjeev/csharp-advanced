/*
 * Attributes and we can create custom attributes
 * Read more for usage
 * */
#define DEBUG
using System;
using System.Linq;
using System.Diagnostics;


namespace SanjjeevWorkouts
{
    public class Test
    {   
        // Conditional only runs when specific preprocessor exist
        // Obsolete gives error when place above function defintion and displays message

        [Conditional("DEBUG")]

        [Obsolete("Try to use new Old Method, Use new Method", true)]

        public void getMessageOld()
        {
            Console.WriteLine("This is test message");
        }

        public void getMessageNew()
        {
            Console.WriteLine("This is new test message");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.getMessageNew();

            Console.ReadKey();
        }
    }
}