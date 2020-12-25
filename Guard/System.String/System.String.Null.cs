using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
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
    public static IGuard Null(this IGuard _, string input)
    {
        return Guard.MustBe.Null(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="parameter"></param>
    /// <returns><paramref name="input" /> if the value is not null.</returns>
    public static IGuard Null(this IGuard _, string input, string parameter)
    {
        return Guard.MustBe.Null(input, parameter, null);
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
    public static IGuard Null(this IGuard _, string input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.Null(paramName);

        if (input.IsNull())
            throw new ArgumentNullException(paramName, message);

        return _;
    }
}
