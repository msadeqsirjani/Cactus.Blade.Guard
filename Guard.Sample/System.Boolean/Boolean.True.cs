using Cactus.Blade.Guard;
using System;

namespace Sample.System.Boolean
{
    public class TrueExecutable : IExecutable
    {
        public void Execute()
        {
            const bool @false = false;
            const bool @true = true;
            const string paramName = "Value";
            const string message = "Value must be false";


            True(@false);
            True(@true);
            True(@false, paramName);
            True(@true, paramName);
            True(@false, null, message);
            True(@true, null, message);
            True(@false, paramName, message);
            True(@true, paramName, message);
        }

        private static void True(bool input)
        {
            try
            {
                Guard.MustBe.True(input);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void True(bool input, string paramName)
        {
            try
            {
                Guard.MustBe.True(input, paramName);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void True(bool input, string paramName, string message)
        {
            try
            {
                Guard.MustBe.True(input, paramName, message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
