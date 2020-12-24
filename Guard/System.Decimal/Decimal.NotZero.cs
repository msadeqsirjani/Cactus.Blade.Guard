using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal NotZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static decimal NotZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static decimal NotZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<decimal>(input, paramName, message);
    }
}