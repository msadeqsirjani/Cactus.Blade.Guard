using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, ushort input)
    {
        return Guard.MustBe.Negative<ushort>(input);
    }

    public static IGuard Negative(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Negative<ushort>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Negative<ushort>(input, paramName, message);
    }
}