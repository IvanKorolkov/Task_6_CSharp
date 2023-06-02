using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lib
{
    internal abstract class GeometricFigure : IFigure
    {

        public Point Center { get; set; }
        protected string Color { get; set; }
        protected bool IsFill { get; set; }

        public abstract string Draw();
        public abstract string Move(int x, int y);
        public abstract string Scale(double factor);
        //public abstract string CalculatePerimetr();
        //public abstract string CalculateArea();



    }
}
