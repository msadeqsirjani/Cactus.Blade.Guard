using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static T Null<T>(this IGuardClause _, T input)
    {
        return Guard.Against.Null<T>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="parameter"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static T Null<T>(this IGuardClause _, T input, string parameter)
    {
        return Guard.Against.Null(input, parameter, null);
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
    public static T Null<T>(this IGuardClause _, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} was null.";

        if (input is null)
            throw new ArgumentNullException(paramName, message);

        return input;
    }
}