﻿using System.Collections.Generic;
using JetBrains.Annotations;
using Widemeadows.MachineLearning.Kohonen.Random;

namespace Widemeadows.MachineLearning.Kohonen.Data
{
    /// <summary>
    /// Interface IDataSet
    /// </summary>
    public interface IDataSet : IEnumerable<IDatum>
    {
        /// <summary>
        /// Picks a random datum from the data.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>IDatum.</returns>
        [NotNull]
        IDatum PickRandom([NotNull] IRandomNumber generator);

        /// <summary>
        /// Gets a value indicating whether this data set supports editing.
        /// </summary>
        /// <value><c>true</c> if this data set supports editing; otherwise, <c>false</c>.</value>
        bool SupportsEdit { get; }

        /// <summary>
        /// Gets a value indicating whether this data set supports creation of new data.
        /// </summary>
        /// <value><c>true</c> if this data set supports creation; otherwise, <c>false</c>.</value>
        bool SupportsCreate { get; }

        /// <summary>
        /// Gets a value indicating whether this data set supports removal.
        /// </summary>
        /// <value><c>true</c> if this data set supports removal; otherwise, <c>false</c>.</value>
        bool SupportsRemove { get; }

        /// <summary>
        /// Edits the specified datum.
        /// </summary>
        /// <param name="datum">The datum.</param>
        /// <returns><c>true</c> if the instance was edited successfully, <c>false</c> otherwise.</returns>
        bool EditDatum([NotNull] IDatum datum);

        /// <summary>
        /// Removes the specified datum.
        /// </summary>
        /// <param name="datum">The datum.</param>
        /// <returns><c>true</c> if the instance was removed successfully, <c>false</c> otherwise.</returns>
        bool RemoveDatum([NotNull] IDatum datum);

        /// <summary>
        /// Creates a new datum.
        /// </summary>
        /// <returns><c>true</c> if the datum was created successfully, <c>false</c> otherwise.</returns>
        bool CreateDatum();
    }
}
