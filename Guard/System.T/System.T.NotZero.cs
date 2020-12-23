using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    public static T NotZero<T>(this IGuard _, T input)
        where T : struct
    {
        input = Guard.Against.NotZero(input, null, null);

        return input;
    }

    public static T NotZero<T>(this IGuard _, T input, string paramName)
        where T : struct
    {
        input = Guard.Against.NotZero(input, paramName, null);

        return input;
    }

    public static T NotZero<T>(this IGuard _, T input, string paramName, string message)
        where T : struct
    {
        paramName ??= nameof(input);
        message ??= Message.NotZero(input);

        if (!EqualityComparer<T>.Default.Equals(input, default))
            throw new ArgumentException(message, paramName);

        return input;
    }
}