using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
