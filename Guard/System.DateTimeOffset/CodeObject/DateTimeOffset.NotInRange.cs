using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static DateTimeOffset NotInRange(this IGuard _, DateTimeOffset value, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        return Guard.MustBe.NotInRange(value, null, null, minimum, maximum);
    }

    public static DateTimeOffset NotInRange(this IGuard _, DateTimeOffset value, string paramName, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        return Guard.MustBe.NotInRange(value, paramName, null, minimum, maximum);
    }

    public static DateTimeOffset NotInRange(this IGuard _, DateTimeOffset value, string paramName, string message, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.NotInRange(value, minimum, maximum);

        if (value.NotInRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}