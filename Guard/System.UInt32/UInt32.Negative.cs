using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint Negative(this IGuard _, uint input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static uint Negative(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static uint Negative(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Negative<uint>(input, paramName, message);
    }
}