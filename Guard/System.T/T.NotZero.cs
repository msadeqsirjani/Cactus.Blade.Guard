using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    public static IGuard NotZero<T>(this IGuard _, T input)
        where T : struct
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static IGuard NotZero<T>(this IGuard _, T input, string paramName)
        where T : struct
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }

    public static IGuard NotZero<T>(this IGuard guard, T input, string paramName, string message)
        where T : struct
    {
        paramName ??= nameof(input);
        message ??= Message.NotZero(paramName);

        if (!EqualityComparer<T>.Default.Equals(input, default))
            throw new ArgumentException(message, paramName);

        return guard;
    }
}