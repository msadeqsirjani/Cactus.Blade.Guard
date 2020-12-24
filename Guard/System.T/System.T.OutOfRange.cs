using Cactus.Blade.Guard;
using System;
using System.Collections.Generic;
using System.ComponentModel;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    internal static T OutOfRange<T>(this IGuard _, T input, T rangeFrom,
        T rangeTo)
    {
        input = Guard.MustBe.OutOfRange<T>(input, null, null, rangeTo, rangeFrom);

        return input;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    internal static T OutOfRange<T>(this IGuard _, T input, string paramName, T rangeFrom,
        T rangeTo)
    {
        input = Guard.MustBe.OutOfRange<T>(input, paramName, null, rangeTo, rangeFrom);

        return input;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static T OutOfRange<T>(this IGuard _, T input, string paramName, string message, T rangeFrom,
        T rangeTo)
    {
        var comparer = Comparer<T>.Default;

        paramName ??= nameof(input);

        if (message.IsNotNullOrEmpty())
        {
            if (comparer.Compare(rangeFrom, rangeTo) > 0)
                message = $"{nameof(rangeFrom)} should be less or equal than {nameof(rangeTo)}";

            if (comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0)
                message = $"Input {paramName} was out of range";
        }

        if (comparer.Compare(rangeFrom, rangeTo) > 0)
            throw new ArgumentException(message);

        if (comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0)
            throw new ArgumentOutOfRangeException(message);

        return input;
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static T OutOfRange<T>(this IGuard _, T input) where T : struct, Enum
    {
        return Guard.MustBe.OutOfRange<T>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static T OutOfRange<T>(this IGuard _, T input, string paramName) where T : struct, Enum
    {
        return Guard.MustBe.OutOfRange<T>(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static T OutOfRange<T>(this IGuard _, T input, string paramName, string message) where T : struct, Enum
    {
        if (!Enum.IsDefined(typeof(T), input))
            throw new InvalidEnumArgumentException(paramName, input.ToInt32(), typeof(T));

        return input;
    }
}