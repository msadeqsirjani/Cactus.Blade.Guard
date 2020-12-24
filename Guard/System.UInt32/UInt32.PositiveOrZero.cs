using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint PositiveOrZero(this IGuard _, uint input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static uint PositiveOrZero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static uint PositiveOrZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<uint>(input, paramName, message);
    }
}