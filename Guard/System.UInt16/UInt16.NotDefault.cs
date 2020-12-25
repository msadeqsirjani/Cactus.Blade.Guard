using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, ushort input)
    {
        return Guard.MustBe.NotDefault<ushort>(input);
    }

    public static IGuard NotDefault(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.NotDefault<ushort>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<ushort>(input, paramName, message);
    }
}