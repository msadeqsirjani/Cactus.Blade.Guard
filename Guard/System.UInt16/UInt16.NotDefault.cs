using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, ushort input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static IGuard NotDefault(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static IGuard NotDefault(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<ushort>(input, paramName, message);
    }
}