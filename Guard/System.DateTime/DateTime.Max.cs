using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Max(DateTime input, DateTime minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(DateTime input, DateTime minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(DateTime input, DateTime minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}