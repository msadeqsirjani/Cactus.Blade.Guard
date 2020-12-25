using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, TimeSpan input)
    {
        return Guard.MustBe.NotDefault<TimeSpan>(input);
    }

    public static IGuard NotDefault(this IGuard _, TimeSpan input, string paramName)
    {
        return Guard.MustBe.NotDefault<TimeSpan>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, TimeSpan input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<TimeSpan>(input, paramName, message);
    }
}