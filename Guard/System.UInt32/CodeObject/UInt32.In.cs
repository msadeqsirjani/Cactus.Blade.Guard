using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static IGuard In(this IGuard _, uint value, params uint[] values)
    {
        return Guard.MustBe.In(value, null, null, values);
    }

    public static IGuard In(this IGuard _, uint value, string paramName, params uint[] values)
    {
        return Guard.MustBe.In(value, paramName, null, values);
    }

    public static IGuard In(this IGuard _, uint value, string paramName, string message, params uint[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}