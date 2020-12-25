using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, TimeSpan input)
    {
        return Guard.MustBe.Default<TimeSpan>(input);
    }

    public static IGuard Default(this IGuard _, TimeSpan input, string paramName)
    {
        return Guard.MustBe.Default<TimeSpan>(input, paramName);
    }

    public static IGuard Default(this IGuard _, TimeSpan input, string paramName, string message)
    {
        return Guard.MustBe.Default<TimeSpan>(input, paramName, message);
    }
}