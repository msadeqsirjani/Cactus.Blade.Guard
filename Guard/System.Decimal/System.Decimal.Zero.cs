using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static decimal Zero(this IGuardClause _, decimal input)
    {
        return Guard.Against.Zero<decimal>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static decimal Zero(this IGuardClause _, decimal input, string paramName)
    {
        return Guard.Against.Zero<decimal>(input, paramName, null);
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
    public static decimal Zero(this IGuardClause _, decimal input, string paramName, string message)
    {
        return Guard.Against.Zero<decimal>(input, paramName, message);
    }
}