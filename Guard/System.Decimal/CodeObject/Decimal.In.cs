using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static decimal In(this IGuard _, decimal value, params decimal[] values)
    {
        return Guard.MustBe.In(value, null, null, values);
    }

    public static decimal In(this IGuard _, decimal value, string paramName, params decimal[] values)
    {
        return Guard.MustBe.In(value, paramName, null, values);
    }

    public static decimal In(this IGuard _, decimal value, string paramName, string message, params decimal[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}