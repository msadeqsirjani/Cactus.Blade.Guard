using System;

namespace Cactus.Blade.Guard
{
    /// <summary>
    /// An entry point to a set of Guard Clauses defined as extension methods on IGuardClause.
    /// </summary>
    /// <remarks>See http://www.weeklydevtips.com/004 on Guard Clauses</remarks>
    public class Guard : IGuardClause
    {
        /// <summary>
        /// An entry point to a set of Guard Clauses.
        /// </summary>
        private static readonly Lazy<IGuardClause> Lazy = new Lazy<IGuardClause>(() => new Guard());

        public static IGuardClause Against => Lazy.Value;

        private Guard()
        {

        }
    }
}
