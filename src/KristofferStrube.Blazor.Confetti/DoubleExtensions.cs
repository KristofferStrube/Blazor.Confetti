using System.Globalization;

namespace KristofferStrube.Blazor.Confetti;

internal static class DoubleExtensions
{
    internal static string AsString(this double d)
    {
        return d.ToString(CultureInfo.InvariantCulture);
    }
}