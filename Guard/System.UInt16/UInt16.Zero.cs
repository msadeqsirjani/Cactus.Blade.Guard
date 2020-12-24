using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort Zero(this IGuard _, ushort input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static ushort Zero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static ushort Zero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Zero<ushort>(input, paramName, message);
    }
}