using System.Drawing;

namespace SlackModel.Core.Extensions
{
    public static class ColorExtensions
    {
        public static string ToRgb(this Color c)
        {
            return $"#{c.R.ToString("X2")}{c.G.ToString("X2")}{c.B.ToString("X2")}";
        }
    }
}