using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Default(this IGuard _, int input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static int Default(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static int Default(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Default<int>(input, paramName, message);
    }
}