using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Max(TimeSpan input, TimeSpan minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(TimeSpan input, TimeSpan minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(TimeSpan input, TimeSpan minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}