using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short NotDefault(this IGuard _, short input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static short NotDefault(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static short NotDefault(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<short>(input, paramName, message);
    }
}