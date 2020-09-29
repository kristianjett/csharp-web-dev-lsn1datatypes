using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("da");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
