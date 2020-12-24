using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static TimeSpan NotDefault(this IGuard _, TimeSpan input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static TimeSpan NotDefault(this IGuard _, TimeSpan input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static TimeSpan NotDefault(this IGuard _, TimeSpan input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<TimeSpan>(input, paramName, message);
    }
}