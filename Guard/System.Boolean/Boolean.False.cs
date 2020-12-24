using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static bool False(this IGuard _, bool input)
    {
        return Guard.MustBe.False(input, null, null);
    }

    public static bool False(this IGuard _, bool input, string paramName)
    {
        return Guard.MustBe.False(input, paramName, null);
    }

    public static bool False(this IGuard _, bool input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.False(paramName);

        if (!input) return false;

        throw new ArgumentException(message, paramName);
    }
}