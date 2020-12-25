using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, uint input)
    {
        return Guard.MustBe.Default<uint>(input);
    }

    public static IGuard Default(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Default<uint>(input, paramName);
    }

    public static IGuard Default(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Default<uint>(input, paramName, message);
    }
}