using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, ushort input)
    {
        return Guard.MustBe.NotZero<ushort>(input);
    }

    public static IGuard NotZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.NotZero<ushort>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<ushort>(input, paramName, message);
    }
}