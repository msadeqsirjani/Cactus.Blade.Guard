using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static ulong In(this IGuard _, ulong value, params ulong[] values)
    {
        return Guard.MustBe.In(value, null, null, values);
    }

    public static ulong In(this IGuard _, ulong value, string paramName, params ulong[] values)
    {
        return Guard.MustBe.In(value, paramName, null, values);
    }

    public static ulong In(this IGuard _, ulong value, string paramName, string message, params ulong[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}