using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, ushort input)
    {
        return Guard.MustBe.Zero<ushort>(input);
    }

    public static IGuard Zero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Zero<ushort>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Zero<ushort>(input, paramName, message);
    }
}