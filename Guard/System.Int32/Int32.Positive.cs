using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Positive(this IGuard _, int input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static int Positive(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static int Positive(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Positive<int>(input, paramName, message);
    }
}