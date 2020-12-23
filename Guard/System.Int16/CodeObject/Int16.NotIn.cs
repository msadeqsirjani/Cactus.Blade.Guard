using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static short NotIn(this IGuard _, short value, params short[] values)
    {
        return Guard.Against.NotIn(value, null, null, values);
    }

    public static short NotIn(this IGuard _, short value, string paramName, params short[] values)
    {
        return Guard.Against.NotIn(value, paramName, null, values);
    }

    public static short NotIn(this IGuard _, short value, string paramName, string message, params short[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}