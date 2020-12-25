using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    private static IGuard Max<T>(this IGuard _, T input, T minimum)
        where T : struct, IComparable
    {
        return Guard.MustBe.Max(input, minimum, null, null);
    }

    private static IGuard Max<T>(this IGuard _, T input, T minimum, string paramName)
        where T : struct, IComparable
    {
        return Guard.MustBe.Max(input, minimum, paramName, null);
    }

    private static IGuard Max<T>(this IGuard guard, T input, T minimum, string paramName, string message)
        where T : struct, IComparable
    {
        paramName ??= nameof(input);
        message ??= Message.Max(paramName, nameof(minimum));

        if (input.CompareTo(minimum) < 0)
            throw new ArgumentException(message, paramName);

        return guard;
    }
}