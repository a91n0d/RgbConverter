using System;
using System.Globalization;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The green valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The blue valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            red = red > 256 ? 255 : red;
            red = red < 0 ? 0 : red;
            green = green > 256 ? 255 : green;
            green = green < 0 ? 0 : green;
            blue = blue > 256 ? 255 : blue;
            blue = blue < 0 ? 0 : blue;

            return string.Format(CultureInfo.InvariantCulture, "{0:x2}{1:x2}{2:x2}", red, green, blue).ToUpper(CultureInfo.InvariantCulture);
        }
    }
}
