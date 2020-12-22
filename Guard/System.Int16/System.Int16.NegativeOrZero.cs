using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static short NegativeOrZero(this IGuardClause _, short input)
    {
        return Guard.Against.NegativeOrZero<short>(input);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static short NegativeOrZero(this IGuardClause _, short input, string paramName)
    {
        return Guard.Against.NegativeOrZero<short>(input, paramName);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static short NegativeOrZero(this IGuardClause _, short input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<short>(input, paramName, message);
    }
}