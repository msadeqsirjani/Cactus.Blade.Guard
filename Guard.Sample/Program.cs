using System;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Operation is starting ...");

            IExecutable executable = new Executable();

            executable.Execute();

            Console.WriteLine("Operation is stopping ...");
        }
    }
}
