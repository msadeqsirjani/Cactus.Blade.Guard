using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard True(this IGuard _, bool input)
    {
        return Guard.MustBe.True(input, null, null);
    }

    public static IGuard True(this IGuard _, bool input, string paramName)
    {
        return Guard.MustBe.True(input, paramName, null);
    }

    public static IGuard True(this IGuard guard, bool input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.True(paramName);

        if (input) return guard;

        throw new ArgumentException(message, paramName);
    }
}