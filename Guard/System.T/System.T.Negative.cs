using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    private static T Negative<T>(this IGuard _, T input)
        where T : struct, IComparable
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    private static T Negative<T>(this IGuard _, T input, string paramName)
        where T : struct, IComparable
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    private static T Negative<T>(this IGuard _, T input, string paramName, string message)
        where T : struct, IComparable
    {
        paramName ??= nameof(input);
        message ??= Message.Negative(input);

        if (input.CompareTo(default(T)) < 0)
            throw new ArgumentException(message, paramName);

        return input;
    }
}