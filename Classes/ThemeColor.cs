using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServer
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#926EAE",
                                                                    "#9966CC",
                                                                    "#926EAE",
                                                                    "#423189",
                                                                    "#7851A9",
                                                                    "#755D9A",
                                                                    "#53377A",
                                                                    "#E6A8D7",
                                                                    "#8673A1",
                                                                    "#9D81BA",
                                                                    "#DDA0DD",
                                                                    "#876C99",
                                                                    "#735184",
                                                                    "#6C4675",};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //Если поправочный коэффициент меньше 0, затемнить цвет.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //Если поправочный коэффициент больше 0, осветлить цвет.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
