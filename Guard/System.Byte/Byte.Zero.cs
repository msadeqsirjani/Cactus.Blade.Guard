using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Zero(this IGuard _, byte input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static byte Zero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static byte Zero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Zero<byte>(input, paramName, message);
    }
}