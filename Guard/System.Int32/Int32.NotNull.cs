using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotNull(int? input)
    {
        return Guard.MustBe.NotNull(input);
    }

    public static IGuard NotNull(int? input, string paramName)
    {
        return Guard.MustBe.NotNull(input, paramName);
    }

    public static IGuard NotNull(int? input, string paramName, string message)
    {
        return Guard.MustBe.NotNull(input, paramName, message);
    }
}