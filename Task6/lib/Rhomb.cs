using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lib
{
    internal class Rhomb : GeometricFigure
    {
        private double Diagonal1;
        private double Diagonal2;

        public Rhomb()
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Diagonal1 = 5;
            this.Diagonal2 = 3;
        }

        public Rhomb(double diagonal1, double diagonal2)
        {
            this.Center = new Point(0, 0);
            this.Color = "Black";
            this.IsFill = false;
            this.Diagonal1 = diagonal1;
            this.Diagonal2 = diagonal2;
        }

        public override string Draw()
        {
            return $"Рисуем ромб: \n Координаты центра: ({Center.X}, {Center.Y}) \n Цвет: {Color} \n Диагонали равны {Diagonal1} и {Diagonal2}\n Закрашен: {IsFill}";
        }

        public override string Move(int x, int y)
        {
            int NewX = this.Center.X;
            int NewY = this.Center.Y;
            NewX += x;
            NewY += y;
            this.Center = new Point(NewX, NewY);
            return $"Переместили ромб на ({x}; {y})";
        }

        public override string Scale(double factor)
        {
            this.Diagonal1 *= factor;
            this.Diagonal2 *= factor;
            return $"Размер ромба изменился в {factor} раз(а)";
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
            return $"Изменили цвет. Был {PrevColor}, стал {color}";
        }

        public string Fill()
        {
            this.IsFill = true;
            return $"При отрисовке ромб будет закрашен";
        }

        public string IsSquare()
        {
            if (Diagonal1 == Diagonal2)
                return "Данный ромб является квадратом";
            else return "Данный ромб не является квадратом";
        }

        public string CalculateSide()
        {
            double side = (Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2)));
            return $"Сторона ромба равна: {side}";
        }

        public string Info()
        {
            return ($"Координаты центра: ({Center.X}, {Center.Y})\nЦвет: {Color}\nДиагонали равны {Diagonal1} и {Diagonal2}\nЗакрашен: {IsFill}");
        }
    }
}
