using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static short In(this IGuard _, short value, params short[] values)
    {
        return Guard.MustBe.In(value, null, null, values);
    }

    public static short In(this IGuard _, short value, string paramName, params short[] values)
    {
        return Guard.MustBe.In(value, paramName, null, values);
    }

    public static short In(this IGuard _, short value, string paramName, string message, params short[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}