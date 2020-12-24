using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static TimeSpan Default(this IGuard _, TimeSpan input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static TimeSpan Default(this IGuard _, TimeSpan input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static TimeSpan Default(this IGuard _, TimeSpan input, string paramName, string message)
    {
        return Guard.MustBe.Default<TimeSpan>(input, paramName, message);
    }
}