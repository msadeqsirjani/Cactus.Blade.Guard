using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, uint input)
    {
        return Guard.MustBe.Positive<uint>(input);
    }

    public static IGuard Positive(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Positive<uint>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Positive<uint>(input, paramName, message);
    }
}