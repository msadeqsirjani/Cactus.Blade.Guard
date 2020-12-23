using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static ushort NotIn(this IGuard _, ushort value, params ushort[] values)
    {
        return Guard.Against.NotIn(value, null, null, values);
    }

    public static ushort NotIn(this IGuard _, ushort value, string paramName, params ushort[] values)
    {
        return Guard.Against.NotIn(value, paramName, null, values);
    }

    public static ushort NotIn(this IGuard _, ushort value, string paramName, string message, params ushort[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}