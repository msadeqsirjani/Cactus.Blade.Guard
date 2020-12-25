using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, byte input)
    {
        return Guard.MustBe.NotZero<byte>(input);
    }

    public static IGuard NotZero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.NotZero<byte>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<byte>(input, paramName, message);
    }
}