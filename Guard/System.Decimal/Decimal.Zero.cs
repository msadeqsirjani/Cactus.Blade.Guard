using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Zero(this IGuard _, decimal input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static decimal Zero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static decimal Zero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Zero<decimal>(input, paramName, message);
    }
}