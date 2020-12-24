using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint NotDefault(this IGuard _, uint input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static uint NotDefault(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static uint NotDefault(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<uint>(input, paramName, message);
    }
}