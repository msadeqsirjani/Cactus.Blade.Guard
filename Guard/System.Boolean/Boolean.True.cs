using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static bool True(this IGuard _, bool input)
    {
        return Guard.MustBe.True(input, null, null);
    }

    public static bool True(this IGuard _, bool input, string paramName)
    {
        return Guard.MustBe.True(input, paramName, null);
    }

    public static bool True(this IGuard _, bool input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.True(paramName);

        if (input) return true;

        throw new ArgumentException(message, paramName);
    }
}