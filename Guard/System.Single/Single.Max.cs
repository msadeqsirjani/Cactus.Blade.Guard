using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Max(float input, float minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(float input, float minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(float input, float minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}