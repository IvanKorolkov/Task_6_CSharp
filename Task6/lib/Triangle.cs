using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    internal class Triangle : GeometricFigure
    {
        private double Side1;
        private double Side2;
        private double Side3;

        public Triangle()
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Side1 = 3;
            this.Side2 = 4;
            this.Side3 = 5;
        }

        public Triangle(double side1, double side2, double side3)
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public override string Draw()
        {
            return $"Рисуем треугольник: \n Координаты центра: ({Center.X}, {Center.Y}) \n Цвет: {Color} \n Стороны равны {Side1}, {Side2}, {Side3}\n Закрашен: {IsFill}";
        }

        public override string Move(int x, int y)
        {
            int NewX = this.Center.X;
            int NewY = this.Center.Y;
            NewX += x;
            NewY += y;
            this.Center = new Point(NewX, NewY);
            return $"Переместили треугольник на ({x}; {y})";
        }

        public override string Scale(double factor)
        {
            this.Side1 *= factor;
            this.Side2 *= factor;
            this.Side3 *= factor;
            return $"Размер треугольника изменился в {factor} раз(а)";
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
            return $"Изменили цвет треугольника. Был {PrevColor}, стал {color}";
        }

        public string Fill()
        {
            this.IsFill = true;
            return $"При отрисовке треугольник будет закрашен";
        }

        public string IsEquilateral()
        {
            if ((Side1 == Side2) && (Side2 == Side3))
                return "Данный треугольник является равносторонним";
            else return "Данный треугольник не является равносторонним";
        }

        public string Info()
        {
            return ($"Координаты центра: ({Center.X}, {Center.Y})\nЦвет: {Color}\nСтороны равны {Side1}, {Side2}, {Side3}\nЗакрашен: {IsFill}");
        }
    }
}
