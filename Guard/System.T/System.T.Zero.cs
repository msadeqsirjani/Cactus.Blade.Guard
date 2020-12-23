using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    public static T Zero<T>(this IGuard _, T input)
        where T : struct
    {
        input = Guard.Against.Zero(input, null, null);

        return input;
    }

    public static T Zero<T>(this IGuard _, T input, string paramName)
        where T : struct
    {
        input = Guard.Against.Zero(input, paramName, null);

        return input;
    }

    public static T Zero<T>(this IGuard _, T input, string paramName, string message)
        where T : struct
    {
        paramName ??= nameof(input);
        message ??= Message.Zero(input);

        if (EqualityComparer<T>.Default.Equals(input, default))
            throw new ArgumentException(message, paramName);

        return input;
    }
}