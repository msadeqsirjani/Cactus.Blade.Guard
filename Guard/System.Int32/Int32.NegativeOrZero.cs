using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int NegativeOrZero(this IGuard _, int input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static int NegativeOrZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static int NegativeOrZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<int>(input, paramName, message);
    }
}