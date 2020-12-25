using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotNull(bool? input)
    {
        return Guard.MustBe.NotNull(input, null, null);
    }

    public static IGuard NotNull(bool? input, string paramName)
    {
        return Guard.MustBe.NotNull(input, paramName, null);
    }

    public static IGuard NotNull(bool? input, string paramName, string message)
    {
        return Guard.MustBe.NotNull(input, paramName, message);
    }
}