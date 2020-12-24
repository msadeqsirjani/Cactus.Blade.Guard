using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static byte NotIn(this IGuard _, byte value, params byte[] values)
    {
        return Guard.MustBe.NotIn(value, null, null, values);
    }

    public static byte NotIn(this IGuard _, byte value, string paramName, params byte[] values)
    {
        return Guard.MustBe.NotIn(value, paramName, null, values);
    }

    public static byte NotIn(this IGuard _, byte value, string paramName, string message, params byte[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}