using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Collections.Generic;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is not default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T NotDefault<T>(this IGuard _, T input)
    {
        return Guard.Against.NotDefault<T>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is not default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T NotDefault<T>(this IGuard _, T input, string paramName)
    {
        return Guard.Against.NotDefault<T>(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T NotDefault<T>(this IGuard _, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.NotDefault(input);

        if (EqualityComparer<T>.Default.Equals(input, default!) || input is null)
            throw new ArgumentException(message, paramName);

        return input;
    }
}