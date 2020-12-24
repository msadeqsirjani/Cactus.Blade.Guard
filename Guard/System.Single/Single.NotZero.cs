using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float NotZero(this IGuard _, float input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static float NotZero(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static float NotZero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<float>(input, paramName, message);
    }
}