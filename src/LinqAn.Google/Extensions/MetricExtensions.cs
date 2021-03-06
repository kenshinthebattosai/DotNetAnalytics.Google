﻿using System;
using System.Collections.Generic;
using System.Linq;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Extensions
{
    /// <summary>
    ///     Useful extensions for the <seealso cref="IMetric" />.
    /// </summary>
    internal static class MetricExtensions
    {
        public static string ToStringRepresentation(this IEnumerable<IMetric> metrics)
        {
            if (metrics == null)
                throw new ArgumentNullException(nameof(metrics), "Metrics cannot be null");
            return string.Join(",", metrics.Select(x => x.Id));
        }
    }
}