using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float NotDefault(this IGuard _, float input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static float NotDefault(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static float NotDefault(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<float>(input, paramName, message);
    }
}