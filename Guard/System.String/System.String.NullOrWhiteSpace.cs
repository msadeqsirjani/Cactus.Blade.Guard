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
    public static string NullOrWhiteSpace(this IGuard _, string input)
    {
        input = Guard.Against.Null(input, null, null);

        return input;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="parameter"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static string NullOrWhiteSpace(this IGuard _, string input, string parameter)
    {
        input = Guard.Against.NullOrWhiteSpace(input, parameter, null);

        return input;
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
    public static string NullOrWhiteSpace(this IGuard _, string input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} was null or empty.";

        if (input.IsNullOrWhiteSpace())
            throw new ArgumentNullException(paramName, message);

        return input;
    }
}
