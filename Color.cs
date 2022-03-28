using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraAssignment3
{
    public class Color
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = 255;
        }

        public int Red { get; set; }
        public int Green { get; set; }

        public int Blue { get; set; }

        public int Alpha { get; set; }

        public double getGrayScale()
        {
            return (this.Red + this.Blue + this.Green) / 3.0;
        }

    }
}
