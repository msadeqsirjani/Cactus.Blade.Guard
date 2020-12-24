using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard NotInRange(this IGuard _, DateTime value, DateTime minimum, DateTime maximum)
    {
        return Guard.MustBe.NotInRange(value, null, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard _, DateTime value, string paramName, DateTime minimum, DateTime maximum)
    {
        return Guard.MustBe.NotInRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard guard, DateTime value, string paramName, string message, DateTime minimum, DateTime maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.NotInRange(value, minimum, maximum);

        if (value.NotInRange(minimum, maximum)) return guard;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}