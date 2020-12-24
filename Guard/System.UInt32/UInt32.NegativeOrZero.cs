using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint NegativeOrZero(this IGuard _, uint input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static uint NegativeOrZero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static uint NegativeOrZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<uint>(input, paramName, message);
    }
}