using Cactus.Blade.Guard;
using System;
using System.Collections.Generic;
using System.Linq;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static IEnumerable<T> NullOrEmpty<T>(this IGuard _, IEnumerable<T> input)
    {
        return Guard.Against.NullOrEmpty(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="parameter"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static IEnumerable<T> NullOrEmpty<T>(this IGuard _, IEnumerable<T> input, string parameter)
    {
        return Guard.Against.NullOrEmpty(input, parameter, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static IEnumerable<T> NullOrEmpty<T>(this IGuard _, IEnumerable<T> input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} was empty.";

        if (!input.Any() || input.Equals(Enumerable.Empty<T>()))
            throw new ArgumentNullException(paramName, message);

        return input;
    }
}