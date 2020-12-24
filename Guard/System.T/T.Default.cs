using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    public static T Default<T>(this IGuard _, T input)
    {
        return Guard.MustBe.Default<T>(input, null, null);
    }

    public static T Default<T>(this IGuard _, T input, string paramName)
    {
        return Guard.MustBe.Default<T>(input, paramName, null);
    }

    public static T Default<T>(this IGuard _, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.Default(paramName);

        if (EqualityComparer<T>.Default.Equals(input, default!) || input is null)
            throw new ArgumentException(message, paramName);

        return input;
    }
}