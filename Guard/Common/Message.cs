using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cactus.Blade.Guard.Common
{
    public static class Message
    {
        public static string State(string input)
            => input.IsNotNull()
                ? $"{input} call is not valid due to the current state of the object."
                : "Operation is not valid due to the current state of the object.";

        public static string Support(string input)
            => input != null ? $"{input} is not supported" : "Specified method is not supported.";

        public static string Disposal()
            => "Cannot access a disposed object.";

        public static string Null<T>(T input)
            => $"{input.GetType().Name} must be null.";

        public static string NotNull<T>(in IGuard _, T input)
            => $"{input.GetType().Name} cannot be null.";

        public static string NotAllNull(string name1, string name2)
            => $"{name1} and {name2} cannot both be null.";

        public static string NotAllNull(string name1, string name2, string name3)
            => $"{name1}, {name2} and {name3} cannot all be null.";

        public static string Default<T>(T input)
            => $"{input.GetType().Name} must be {default(T)!}.";

        public static string NotDefault<T>(T input)
            => $"{input.GetType().Name} cannot be {default(T)!}.";

        public static string Equal<T>(T input, T other)
            => $"{input.GetType().Name} must be {ToString(other)}.";

        public static string NotEqual<T>(T input, T other)
            => $"{input.GetType().Name} cannot be {ToString(other)}.";

        public static string Equal<T>(T input, T other, T delta)
            => $"{input.GetType().Name} must be within {delta} accuracy of {other}.";

        public static string NotEqual<T>(T input, T other, T delta)
            => $"{input.GetType().Name} cannot be within {delta} accuracy of {other}.";

        public static string Same<T>(T input, T other)
            => $"{input.GetType().Name} must have the same reference as {ToString(other)}.";

        public static string NotSame<T>(T input, T other)
            => $"{input.GetType().Name} cannot have the same reference as {ToString(other)}.";

        public static string Require<T>(T input)
            => $"{input.GetType().Name} is invalid.";

        public static string Type(Type input, Type type)
            => $"{input} must be an instance of type {type}.";

        public static string NotType(Type input, Type type)
            => $"{input} cannot be an instance of type {type}.";

        public static string Compatible<TArgument, TTarget, T>(this IGuard _)
            => $"{typeof(TArgument)} must be assignable to type {typeof(TTarget)}.";

        public static string NotCompatible<TArgument, TTarget>(this IGuard _)
            => $"{typeof(TArgument)} cannot be assignable to type {typeof(TTarget)}.";

        public static string Min<T>(T input, T minInput)
            => $"{input.GetType().Name} cannot be less than {minInput}.";

        public static string GreaterThan<T>(T input, T other)
            => $"{input.GetType().Name} must be greater than {other}.";

        public static string Max<T>(T input, T maxInput)
            => $"{input.GetType().Name} cannot be greater than {maxInput}.";

        public static string LessThan<T>(T input, T other)
            => $"{input.GetType().Name} must be less than {other}.";

        public static string Zero<T>(T input)
            => $"{input.GetType().Name} must be zero.";

        public static string NotZero<T>(T input)
            => $"{input.GetType().Name} cannot be zero.";

        public static string Positive<T>(T input)
            => $"{input.GetType().Name} must be greater than zero.";

        public static string PositiveOrZero<T>(T input)
            => $"{input.GetType().Name} must be greater than or equal to zero.";

        public static string NotPositive<T>(T input)
            => $"{input.GetType().Name} must be zero or less.";

        public static string Negative<T>(T input)
            => $"{input.GetType().Name} must be less than zero.";

        public static string NegativeOrZero<T>(T input)
            => $"{input.GetType().Name} must be less than or equal to zero.";

        public static string NotNegative<T>(T input)
            => $"{input.GetType().Name} must be zero or greater.";

        public static string InRange<T>(T input, T minInput, T maxInput)
            => $"{input.GetType().Name} must be between {minInput} and {maxInput}";

        public static string NotInRange<T>(T input, T minInput, T maxInput)
            => $"{input.GetType().Name} must not be between {minInput} and {maxInput}";

        public static string NaN<T>(T input)
            => $"{input.GetType().Name} must be not a number (NaN).";

        public static string NotNaN<T>(T input)
            => $"{input.GetType().Name} cannot be not a number (NaN).";

        public static string Infinity<T>(T input)
            => $"{input.GetType().Name} must be positive or negative infinity.";

        public static string NotInfinity<T>(T input)
            => $"{input.GetType().Name} cannot be positive or negative infinity.";

        public static string PositiveInfinity<T>(T input)
            => $"{input.GetType().Name} must be positive infinity (∞).";

        public static string NotPositiveInfinity<T>(T input)
            => $"{input.GetType().Name} cannot be positive infinity (∞).";

        public static string NegativeInfinity<T>(T input)
            => $"{input.GetType().Name} must be negative infinity -(∞).";

        public static string NotNegativeInfinity<T>(T input)
            => $"{input.GetType().Name} cannot be negative infinity (-∞).";

        public static string StringEmpty<T>(T input)
            => $"{input.GetType().Name} must be empty.";

        public static string StringNotEmpty<T>(T input)
            => $"{input.GetType().Name} cannot be empty.";

        public static string StringWhiteSpace(object input)
            => $"{input.GetType().Name} must be empty or consist only of white-space characters.";

        public static string StringNotWhiteSpace(string input)
            => $"{input.GetType().Name} cannot be empty or consist only of white-space characters.";

        public static string StringLength(string input, int length)
            => $"{input.GetType().Name} must consist of {length} characters.";

        public static string StringNotLength(string input, int length)
            => $"{input.GetType().Name} cannot consist of {length} characters.";

        public static string StringMinLength(string input, int minLength)
            => $"{input.GetType().Name} cannot be shorter than {minLength} characters.";

        public static string StringMaxLength(string input, int maxLength)
            => $"{input.GetType().Name} cannot be longer than {maxLength} characters.";

        public static string StringLengthInRange(string input, int minLength, int maxLength)
            => $"{input.GetType().Name} must contain {minLength} to {maxLength} characters.";

        public static string StringStartsWith(string input)
            => $"{input.GetType().Name} must start with '{input}'.";

        public static string StringDoesNotStartWith(string input)
            => $"{input.GetType().Name} cannot start with '{input}'.";

        public static string StringEndsWith(string input)
            => $"{input.GetType().Name} must end with '{input}'.";

        public static string StringDoesNotEndWith(string input)
            => $"{input.GetType().Name} cannot end with '{input}'.";

        public static string StringMatches(string input, string pattern)
            => $"No match in {input.GetType().Name} could be found by the regular expression '{pattern}'.";

        public static string StringMatchesTimeout(string input, string pattern, TimeSpan matchTimeout)
            =>
                $"No match in {input.GetType().Name} could be found by the regular expression '{pattern}' in {matchTimeout}";

        public static string StringDoesNotMatch(string input, string pattern)
            => $"A match in {input.GetType().Name} is found by the regular expression '{pattern}'.";

        public static string StringDoesNotMatchTimeout(string input, string pattern,
            TimeSpan matchTimeout)
            =>
                $"{input.GetType().Name} could not entirely be searched by the regular expression '{pattern}' due to time-out {matchTimeout}";

        public static string In<T>(T value, params T[] values)
            => $"{value.GetType().Name} must be in {Join(values)}.";

        public static string NotIn<T>(T value, params T[] values)
            => $"{value.GetType().Name} must not be in {Join(values)}.";

        public static string Between<T>(T value, T minimum, T maximum)
            => $"{value.GetType().Name} must be between {minimum} and {maximum}.";

        public static string True(bool input)
            => $"{input.GetType().Name} must be true.";

        public static string False(bool input)
            => $"{input.GetType().Name} must be false.";

        public static string Enum<T>(T input)
            => $"{input.GetType().Name} is not an enum input.";

        public static string EnumDefined<T>(T input)
            => $"{input.GetType().Name} is not a defined {typeof(T)} member.";

        public static string EnumNone<T>(T input)
            => $"{input.GetType().Name} cannot have any of its bits set.";

        public static string EnumNotNone<T>(T input)
            => $"{input.GetType().Name} must have at least one of its bits set.";

        public static string EnumHasFlag<T>(T input, T flag)
            => $"{input.GetType().Name} does not has the {flag} flag.";

        public static string EnumDoesNotHaveFlag<T>(T input, T flag)
            => $"{input.GetType().Name} cannot have the {flag} flag.";

        public static string EnumerableEmpty<T>(T input)
            => $"{input.GetType().Name} must be empty.";

        public static string EnumerableNotEmpty<T>(T input)
            => $"{input.GetType().Name} cannot be empty.";

        public static string EnumerableCount<T>(T input, int count)
            => $"{input.GetType().Name} must consist of {count} items.";

        public static string EnumerableNotCount<T>(T input, int count)
            => $"{input.GetType().Name} cannot consist of {count} items.";

        public static string EnumerableMinCount<T>(T input, int minCount)
            => $"{input.GetType().Name} must contain at least {minCount} items.";

        public static string EnumerableMaxCount<T>(T input, int maxCount)
            => $"{input.GetType().Name} cannot contain more than {maxCount} items.";

        public static string EnumerableCountInRange<T>(T input, int minCount, int maxCount)
            => $"{input.GetType().Name} must contain {minCount} to {maxCount} items.";

        public static string EnumerableContains<T>(IEnumerable<T> enumerable, T input)
            => $"{input.GetType().Name} must contain {Join(enumerable)}.";

        public static string EnumerableDoesNotContain<T>(IEnumerable<T> enumerable, T input)
            => $"{input.GetType().Name} cannot contain {Join(enumerable)}.";

        public static string InEnumerable<T>(IEnumerable<T> enumerable, T input)
            => $"{input.GetType().Name} must be one of the following: {Join(enumerable)}";

        public static string NotInEnumerable<T>(IEnumerable<T> enumerable, T input)
            => $"{input.GetType().Name} cannot be one of the following: {Join(enumerable)}";

        public static string UriAbsolute(Uri input)
            => $"{input.GetType().Name} must be an absolute URI.";

        public static string UriRelative(Uri input)
            => $"{input.GetType().Name} must be a relative URI.";

        public static string UriScheme(Uri input, string scheme)
            => $"{input.GetType().Name} must be an absolute URI with the {scheme} scheme.";

        public static string UriNotScheme(Uri input, string scheme)
            => $"{input.GetType().Name} cannot have the {scheme} scheme.";

        public static string UriHttp(Uri input)
            => $"{input.GetType().Name} must be an absolute URI with the HTTP scheme.";

        public static string UriHttps(Uri input)
            => $"{input.GetType().Name} must be an absolute URI with the HTTPS scheme.";

        public static string KindSpecified<T>(T input)
            => $"{input.GetType().Name} must have its kind specified.";

        public static string KindUnspecified<T>(T input)
            => $"{input.GetType().Name} cannot have its kind specified.";

        private static string ToString(object obj) => obj?.ToString() ?? "null";

        private static string Join(IEnumerable enumerable)
        {
            const int max = 5;

            var objects = enumerable is IEnumerable<string> e
                ? e.Select(i => $"\"{i}\"")
                : enumerable.Cast<object>();

            var list = objects.Take(max + 1).ToList();
            var ellipsis = list.Count > max;
            if (ellipsis)
                list.RemoveAt(max);

            var result = string.Join(", ", list);
            if (ellipsis)
                result += "...";

            return result;
        }
    }
}
