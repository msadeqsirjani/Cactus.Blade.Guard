using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int NotDefault(this IGuard _, int input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static int NotDefault(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static int NotDefault(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<int>(input, paramName, message);
    }
}