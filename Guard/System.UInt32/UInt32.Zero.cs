using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, uint input)
    {
        return Guard.MustBe.Zero<uint>(input);
    }

    public static IGuard Zero(this IGuard _, uint input, string paramName)
    {
        return Guard.MustBe.Zero<uint>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.MustBe.Zero<uint>(input, paramName, message);
    }
}