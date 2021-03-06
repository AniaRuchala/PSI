﻿using System.ComponentModel.Composition;
using System.Threading;
using Widemeadows.MachineLearning.Kohonen.Model;

namespace Widemeadows.MachineLearning.Kohonen.Random
{
    /// <summary>
    /// Class StandardRng. This class cannot be inherited.
    /// </summary>
    [Export(typeof(IRandomNumber))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [InternalIdMetadata("36F57512-A94B-4ACE-9B77-63B8ACF30821", "Default RNG", "1.0.0.0", IsDefault = true)]
    public sealed class StandardRng : IRandomNumber
    {
        /// <summary>
        /// The random number generator instance
        /// </summary>
        private System.Random _random = new System.Random();

        /// <summary>
        /// Sets the seed for the generator.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public void SetSeed(long seed)
        {
            unchecked
            {
                var intSeed = (int) seed;
                var newRandom = new System.Random(intSeed);
                Interlocked.Exchange(ref _random, newRandom);
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Double" /> value in the range of <paramref name="min" /> to <paramref name="max" />.
        /// </summary>
        /// <param name="min">The minimum value (inclusive).</param>
        /// <param name="max">The maximum value (inclusive).</param>
        /// <returns>System.Double.</returns>
        public double GetDouble(double min = 0, double max = 1)
        {
            var random = _random;
            var number = random.NextDouble();
            var scaledNumber = number*(max - min) + min;
            return scaledNumber;
        }
    }
}
