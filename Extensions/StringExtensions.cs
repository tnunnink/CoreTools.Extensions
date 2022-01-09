using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    /// <summary>
    /// Class containing extensions for <see cref="string"/> objects.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines if the current string is equal to <see cref="string.Empty"/>.
        /// </summary>
        /// <param name="value">The string input to evaluate.</param>
        /// <returns>true if the string is empty; otherwise, false.</returns>
        public static bool IsEmpty(this string value) => string.Equals(value, string.Empty);
        
        /// <summary>
        /// Replaces all specified string values with a single replacement string value in the current string.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="items"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        public static string ReplaceAll(this string value, IEnumerable<string> items, string replacement)
        {
            return items.Aggregate(value, (str, cItem) => str.Replace(cItem, replacement));
        }
    }
}