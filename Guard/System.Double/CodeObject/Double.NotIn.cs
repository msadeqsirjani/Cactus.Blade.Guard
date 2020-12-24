using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static double NotIn(this IGuard _, double value, params double[] values)
    {
        return Guard.MustBe.NotIn(value, null, null, values);
    }

    public static double NotIn(this IGuard _, double value, string paramName, params double[] values)
    {
        return Guard.MustBe.NotIn(value, paramName, null, values);
    }

    public static double NotIn(this IGuard _, double value, string paramName, string message, params double[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}