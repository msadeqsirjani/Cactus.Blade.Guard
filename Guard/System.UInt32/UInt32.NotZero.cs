using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint NotZero(this IGuard _, uint input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static uint NotZero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static uint NotZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<uint>(input, paramName, message);
    }
}