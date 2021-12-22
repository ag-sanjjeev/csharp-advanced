/*
 * Reflections are used to get type of information when runtime
 * and mostly preferable for debug information
 * */

using System;
using System.Linq;

/* Attribute definitions */

public class HelpAttribute : System.Attribute
{
    public readonly string Url;

    public string Topic
    {
        get { return topic; }
        set { topic = value;  }
    }

    private string topic;
    public HelpAttribute(string url)
    {
        this.Url = url;
    }
}

/* Attribute definitions end */

[HelpAttribute("Information on the class TestClass")]
class TestClass
{
    public string text;
}

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo Info = typeof(TestClass);
            object[] attributes = Info.GetCustomAttributes(true);

            for (int i=0; i<attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }

            Console.ReadKey();
        }
    }
}