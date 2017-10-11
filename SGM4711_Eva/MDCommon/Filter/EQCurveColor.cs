using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SGM4711_Eva.MDCommon.Filter
{
    public static class FilterCurveColor
    {
        private static Color[] colors = new Color[] { Color.Blue, Color.Cyan, Color.GreenYellow, Color.IndianRed, Color.Green, Color.Purple};
        private static Color EQDefault = Color.DarkGray;

        public static Color FilterCurveColors(int ix)
        {
            return colors[ix];
        }

        public static Color EQCurveColor
        {
            get { return EQDefault; }
        }

    }
}
