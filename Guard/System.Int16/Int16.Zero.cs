using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short Zero(this IGuard _, short input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static short Zero(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static short Zero(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.Zero<short>(input, paramName, message);
    }
}