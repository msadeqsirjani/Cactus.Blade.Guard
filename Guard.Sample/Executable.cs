using Sample.System.Boolean;

namespace Sample
{
    public class Executable : IExecutable
    {
        public void Execute()
        {
            Boolean();
        }

        private static void Boolean()
        {
            IExecutable boolean = new FalseExecutable();

            boolean.Execute();

            boolean = new TrueExecutable();

            boolean.Execute();
        }
    }
}
