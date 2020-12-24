using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static T Null<T>(this IGuard _, T input)
    {
        return Guard.MustBe.Null<T>(input, null, null);
    }

    public static T Null<T>(this IGuard _, T input, string parameter)
    {
        return Guard.MustBe.Null(input, parameter, null);
    }

    public static T Null<T>(this IGuard _, T input, string paramName, string message)
    {
        paramName ??= nameof(input);
        message ??= Message.Null(paramName);

        if (input is null)
            throw new ArgumentNullException(paramName, message);

        return input;
    }
}