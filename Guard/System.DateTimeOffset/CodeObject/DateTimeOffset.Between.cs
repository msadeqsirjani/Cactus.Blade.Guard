using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard Between(this IGuard _, DateTimeOffset value, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, DateTimeOffset value, string paramName, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard guard, DateTimeOffset value, string paramName, string message, DateTimeOffset minimum, DateTimeOffset maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return guard;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}