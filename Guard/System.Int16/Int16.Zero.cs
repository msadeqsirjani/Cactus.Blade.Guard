﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, short input)
    {
        return Guard.MustBe.Zero<double>(input);
    }

    public static IGuard Zero(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.Zero<double>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.Zero<short>(input, paramName, message);
    }
}