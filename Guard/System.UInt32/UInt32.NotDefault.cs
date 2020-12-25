using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, uint input)
    {
        return Guard.MustBe.NotDefault<uint>(input);
    }

    public static IGuard NotDefault(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NotDefault<uint>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<uint>(input, paramName, message);
    }
}