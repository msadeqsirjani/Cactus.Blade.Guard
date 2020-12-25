using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, ushort input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static IGuard Positive(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static IGuard Positive(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Positive<ushort>(input, paramName, message);
    }
}