using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Positive(this IGuard _, byte input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static byte Positive(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static byte Positive(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Positive<byte>(input, paramName, message);
    }
}