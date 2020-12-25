using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Max(int input, int minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(int input, int minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(int input, int minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}