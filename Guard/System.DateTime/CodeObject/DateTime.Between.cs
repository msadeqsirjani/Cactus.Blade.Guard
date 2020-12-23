using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static DateTime Between(this IGuard _, DateTime value, DateTime minimum, DateTime maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static DateTime Between(this IGuard _, DateTime value, string paramName, DateTime minimum, DateTime maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static DateTime Between(this IGuard _, DateTime value, string paramName, string message, DateTime minimum, DateTime maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}