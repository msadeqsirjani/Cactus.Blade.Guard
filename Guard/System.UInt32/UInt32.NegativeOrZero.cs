using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, uint input)
    {
        return Guard.MustBe.NegativeOrZero<uint>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<uint>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<uint>(input, paramName, message);
    }
}