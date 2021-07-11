using System.Text.RegularExpressions;

namespace TeeBox.Application.Models.Map
{
    public static class MapExtensions
    {
        public static double RemoveUnits(this string value)
        {
            return double.Parse(Regex.Replace(value, "[^0-9.]", ""));
        }
    }
}
