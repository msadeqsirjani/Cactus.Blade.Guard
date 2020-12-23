using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static byte NotInRange(this IGuard _, byte value, byte minimum, byte maximum)
    {
        return Guard.Against.NotInRange(value, null, null, minimum, maximum);
    }

    public static byte NotInRange(this IGuard _, byte value, string paramName, byte minimum, byte maximum)
    {
        return Guard.Against.NotInRange(value, paramName, null, minimum, maximum);
    }

    public static byte NotInRange(this IGuard _, byte value, string paramName, string message, byte minimum, byte maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.NotInRange(value, minimum, maximum);

        if (((short)value).NotInRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}