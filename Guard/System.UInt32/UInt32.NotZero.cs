using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, uint input)
    {
        return Guard.MustBe.NotZero<uint>(input);
    }

    public static IGuard NotZero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NotZero<uint>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<uint>(input, paramName, message);
    }
}