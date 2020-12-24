using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal NotDefault(this IGuard _, decimal input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static decimal NotDefault(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static decimal NotDefault(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<decimal>(input, paramName, message);
    }
}