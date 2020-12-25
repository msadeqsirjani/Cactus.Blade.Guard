using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    public static IGuard Default<T>(this IGuard _, T input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static IGuard Default<T>(this IGuard _, T input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static IGuard Default<T>(this IGuard guard, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.Default(paramName);

        if (!(EqualityComparer<T>.Default.Equals(input, default!) || input is null))
            throw new ArgumentException(message, paramName);

        return guard;
    }
}