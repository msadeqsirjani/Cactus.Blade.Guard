using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static double InRange(this IGuard _, double value, double minimum, double maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static double InRange(this IGuard _, double value, string paramName, double minimum, double maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static double InRange(this IGuard _, double value, string paramName, string message, double minimum, double maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}