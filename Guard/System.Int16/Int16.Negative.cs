using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short Negative(this IGuard _, short input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static short Negative(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static short Negative(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.Negative<short>(input, paramName, message);
    }
}