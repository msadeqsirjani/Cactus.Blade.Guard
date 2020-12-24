using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Negative(this IGuard _, decimal input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static decimal Negative(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static decimal Negative(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Negative<decimal>(input, paramName, message);
    }
}