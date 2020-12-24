using System;

namespace Cactus.Blade.Guard
{
    /// <summary>
    /// An entry point to a set of <see cref="Guard"/> defined as extension methods on <see cref="IGuard"/>.
    /// </summary>
    public class Guard : IGuard
    {
        private static readonly Lazy<IGuard> Lazy = new Lazy<IGuard>(() => new Guard());

        /// <summary>
        /// An entry point to a set of <see cref="Guard"/>.
        /// </summary>
        public static IGuard MustBe => Lazy.Value;

        private Guard()
        {

        }
    }
}
