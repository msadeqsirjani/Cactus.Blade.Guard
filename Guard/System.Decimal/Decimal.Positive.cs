using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Positive(this IGuard _, decimal input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static decimal Positive(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static decimal Positive(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Positive<decimal>(input, paramName, message);
    }
}