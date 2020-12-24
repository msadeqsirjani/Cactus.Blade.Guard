using Cactus.Blade.Guard;
using System;

namespace Sample.System.Boolean
{
    public class FalseExecutable : IExecutable
    {
        public void Execute()
        {
            const bool @false = false;
            const bool @true = true;
            const string paramName = "Value";
            const string message = "Value must be false";


            False(@false);
            False(@true);
            False(@false, paramName);
            False(@true, paramName);
            False(@false, null, message);
            False(@true, null, message);
            False(@false, paramName, message);
            False(@true, paramName, message);
        }

        private static void False(bool input)
        {
            try
            {
                Guard.MustBe.False(input);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void False(bool input, string paramName)
        {
            try
            {
                Guard.MustBe.False(input, paramName);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void False(bool input, string paramName, string message)
        {
            try
            {
                Guard.MustBe.False(input, paramName, message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
