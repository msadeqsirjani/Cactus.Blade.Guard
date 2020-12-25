using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, uint input)
    {
        return Guard.MustBe.Negative<uint>(input);
    }

    public static IGuard Negative(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Negative<uint>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Negative<uint>(input, paramName, message);
    }
}