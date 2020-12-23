using System;

namespace Cactus.Blade.Guard
{
    /// <summary>
    /// An entry point to a set of Guard Clauses defined as extension methods on IGuardClause.
    /// </summary>
    public class Guard : IGuard
    {
        /// <summary>
        /// An entry point to a set of Guard Clauses.
        /// </summary>
        private static readonly Lazy<IGuard> Lazy = new Lazy<IGuard>(() => new Guard());

        public static IGuard Against => Lazy.Value;

        private Guard()
        {

        }
    }
}
