using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotNull(DateTime? input)
    {
        return Guard.MustBe.NotNull(input);
    }

    public static IGuard NotNull(DateTime? input, string paramName)
    {
        return Guard.MustBe.NotNull(input, paramName);
    }

    public static IGuard NotNull(DateTime? input, string paramName, string message)
    {
        return Guard.MustBe.NotNull(input, paramName, message);
    }
}