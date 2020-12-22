using System;
using System.Collections.Generic;
using System.Text;
using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T Zero<T>(this IGuard _, T input)
        where T : struct
    {
        input = Guard.Against.Zero(input, null, null);

        return input;
    }
    
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T Zero<T>(this IGuard _, T input, string paramName)
        where T : struct
    {
        input = Guard.Against.Zero(input, paramName, null);

        return input;
    }
    
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static T Zero<T>(this IGuard _, T input, string paramName, string message)
        where T : struct
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} cannot be zero.";

        if (EqualityComparer<T>.Default.Equals(input, default))
            throw new ArgumentException(message, paramName);

        return input;
    }
}