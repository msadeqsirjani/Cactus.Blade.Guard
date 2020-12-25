using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, decimal input)
    {
        return Guard.MustBe.Zero<decimal>(input);
    }

    public static IGuard Zero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Zero<decimal>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Zero<decimal>(input, paramName, message);
    }
}