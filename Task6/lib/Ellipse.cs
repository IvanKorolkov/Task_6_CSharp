using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    internal class Ellipse : GeometricFigure
    {
        private double Focus1;
        private double Focus2;

        public Ellipse()
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Focus1 = 5;
            this.Focus2 = 3;
        }

        public Ellipse(double focus1, double focus2)
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Focus1 = focus1;
            this.Focus2 = focus2;
        }

        public override string Draw()
        {
            return $"Рисуем эллипс: \n Координаты центра: ({Center.X}, {Center.Y}) \n Цвет: {Color} \n Фокусы равны {Focus1} и {Focus2}\n Закрашен: {IsFill}";
        }

        public override string Move(int x, int y)
        {
            int NewX = this.Center.X;
            int NewY = this.Center.Y;
            NewX += x;
            NewY += y;
            this.Center = new Point(NewX, NewY);
            return $"Переместили эллипс на ({x}; {y})";
        }

        public override string Scale(double factor)
        {
            this.Focus1 *= factor;
            this.Focus2 *= factor;
            return $"Размер эллипса изменился в {factor} раз(а)";
        }

        /*
        public override string CalculateArea()
        {
            double area = ((Diagonal1 * Diagonal2) / 2);
            return $"Площадь ромба равна: {area}";

        }
        public override string CalculatePerimetr()
        {
            double perimetr = 4 * (Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2)));
            return $"Периметр ромба равна: {perimetr}";
        }
        */
        public string ChangeColor(string color)
        {
            string PrevColor = this.Color;
            this.Color = color;
            return $"Изменили цвет эллипса. Был {PrevColor}, стал {color}";
        }

        public string Fill()
        {
            this.IsFill = true;
            return $"При отрисовке эллипс будет закрашен";
        }

        public string IsCircle()
        {
            if (Focus1 == Focus2)
                return "Данный эллипс является кругом";
            else return "Данный эллипс не является кругом";
        }

        public string Info()
        {
            return ($"Координаты центра: ({Center.X}, {Center.Y})\nЦвет: {Color}\nФокус равны {Focus1} и {Focus2}\nЗакрашен: {IsFill}");
        }
    }
}
