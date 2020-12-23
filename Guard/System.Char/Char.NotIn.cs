using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using Cactus.Blade.Guard.Common.Exceptions;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static char In(this IGuard _, char value, params char[] values)
    {
        return Guard.Against.In(value, null, null, values);
    }

    public static char In(this IGuard _, char value, string paramName, params char[] values)
    {
        return Guard.Against.In(value, paramName, null, values);
    }

    public static char In(this IGuard _, char value, string paramName, string message, params char[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return value;

        throw new ArgumentNotInRangeException(message, paramName);
    }
}