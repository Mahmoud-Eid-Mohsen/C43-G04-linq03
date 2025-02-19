
using System.Diagnostics.CodeAnalysis;

namespace Assignment
{
    internal class custmstringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return string.Concat(x.OrderBy(c => c)) == string.Concat(y.OrderBy(c => c));
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return HashCode.Combine(obj.GetHashCode());
        }
    }
}