using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard NotNull<T>(this IGuard _, T input)
    {
        return Guard.MustBe.NotNull(input, null, null);
    }

    public static IGuard NotNull<T>(this IGuard _, T input, string parameter)
    {
        return Guard.MustBe.NotNull(input, parameter, null);
    }

    public static IGuard NotNull<T>(this IGuard guard, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.NotNull(paramName);

        if (input is null)
            throw new ArgumentNullException(paramName, message);

        return guard;
    }
}