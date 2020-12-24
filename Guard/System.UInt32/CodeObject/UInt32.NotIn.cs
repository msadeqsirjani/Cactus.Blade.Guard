using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static uint NotIn(this IGuard _, uint value, params uint[] values)
    {
        return Guard.MustBe.NotIn(value, null, null, values);
    }

    public static uint NotIn(this IGuard _, uint value, string paramName, params uint[] values)
    {
        return Guard.MustBe.NotIn(value, paramName, null, values);
    }

    public static uint NotIn(this IGuard _, uint value, string paramName, string message, params uint[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}