using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static float InRange(this IGuard _, float value, float minimum, float maximum)
    {
        return Guard.MustBe.InRange(value, null, null, minimum, maximum);
    }

    public static float InRange(this IGuard _, float value, string paramName, float minimum, float maximum)
    {
        return Guard.MustBe.InRange(value, paramName, null, minimum, maximum);
    }

    public static float InRange(this IGuard _, float value, string paramName, string message, float minimum, float maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}