using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    private static IGuard Positive<T>(this IGuard _, T input)
        where T : struct, IComparable
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    private static IGuard Positive<T>(this IGuard _, T input, string paramName)
        where T : struct, IComparable
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    private static IGuard Positive<T>(this IGuard guard, T input, string paramName, string message)
        where T : struct, IComparable
    {
        paramName ??= nameof(input);
        message ??= Message.Positive(paramName);

        if (input.CompareTo(default(T)) > 0)
            throw new ArgumentException(message, paramName);

        return guard;
    }
}