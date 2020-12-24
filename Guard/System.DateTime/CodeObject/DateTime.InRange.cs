using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard InRange(this IGuard _, DateTime value, DateTime minimum, DateTime maximum)
    {
        return Guard.MustBe.InRange(value, null, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard _, DateTime value, string paramName, DateTime minimum, DateTime maximum)
    {
        return Guard.MustBe.InRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard guard, DateTime value, string paramName, string message, DateTime minimum, DateTime maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return guard;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}