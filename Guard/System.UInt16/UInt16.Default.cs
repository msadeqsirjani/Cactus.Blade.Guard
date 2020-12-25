using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, ushort input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static IGuard Default(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static IGuard Default(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Default<ushort>(input, paramName, message);
    }
}