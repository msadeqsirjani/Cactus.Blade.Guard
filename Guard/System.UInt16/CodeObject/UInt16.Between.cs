using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static ushort Between(this IGuard _, ushort value, ushort minimum, ushort maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static ushort Between(this IGuard _, ushort value, string paramName, ushort minimum, ushort maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static ushort Between(this IGuard _, ushort value, string paramName, string message, ushort minimum, ushort maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}