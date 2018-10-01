using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator
{
    public static class Calculator
    {
        public static double CalculateArea(Figure figure)
        {
            return Math.Round(figure.GetArea(), 2);
        }
    }
}
