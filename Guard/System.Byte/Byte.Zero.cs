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
    public static byte Zero(this IGuard _, byte input)
    {
        return Guard.Against.Zero<byte>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static byte Zero(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.Zero<byte>(input, paramName, null);
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
    public static byte Zero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.Zero<byte>(input, paramName, message);
    }
}