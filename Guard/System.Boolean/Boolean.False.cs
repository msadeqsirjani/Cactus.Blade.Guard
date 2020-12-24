using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard False(this IGuard _, bool input)
    {
        return Guard.MustBe.False(input, null, null);
    }

    public static IGuard False(this IGuard _, bool input, string paramName)
    {
        return Guard.MustBe.False(input, paramName, null);
    }

    public static IGuard False(this IGuard guard, bool input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.False(paramName);

        if (!input) return guard;

        throw new ArgumentException(message, paramName);
    }
}