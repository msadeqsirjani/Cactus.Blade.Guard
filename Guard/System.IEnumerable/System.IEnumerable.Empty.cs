using Cactus.Blade.Guard;
using System;
using System.Collections.Generic;
using System.Linq;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is Empty.
    /// </summary>
    /// <typeparam name="TCollection"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not Empty.</returns>
    public static IEnumerable<TCollection> Empty<TCollection>(this IGuard _, IEnumerable<TCollection> input, Func<TCollection, bool> predicate = null)
    {
        return Guard.Against.Empty(input, null, null, predicate);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is Empty.
    /// </summary>
    /// <typeparam name="TCollection"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="parameter"></param>
    /// <returns><paramref name="input" /> if the value is not Empty.</returns>
    public static IEnumerable<TCollection> Empty<TCollection>(this IGuard _, IEnumerable<TCollection> input, string parameter, Func<TCollection, bool> predicate = null)
    {
        return Guard.Against.Empty(input, parameter, null, predicate);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is Empty.
    /// </summary>
    /// <typeparam name="TCollection"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not Empty.</returns>
    public static IEnumerable<TCollection> Empty<TCollection>(this IGuard _, IEnumerable<TCollection> input, string paramName, string message, Func<TCollection, bool> predicate = null)
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} was empty.";

        if (predicate.IsNotNull())
            input = input.Where(c => predicate != null && predicate(c));

        if (!input.Any())
            throw new ArgumentNullException(paramName, message);

        return input;
    }
}