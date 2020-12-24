using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint Default(this IGuard _, uint input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static uint Default(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static uint Default(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Default<uint>(input, paramName, message);
    }
}