using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static char NotIn(this IGuard _, char value, params char[] values)
    {
        return Guard.MustBe.NotIn(value, null, null, values);
    }

    public static char NotIn(this IGuard _, char value, string paramName, params char[] values)
    {
        return Guard.MustBe.NotIn(value, paramName, null, values);
    }

    public static char NotIn(this IGuard _, char value, string paramName, string message, params char[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}