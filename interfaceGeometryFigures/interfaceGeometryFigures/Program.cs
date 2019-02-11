using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGeometryFigures
{
    interface IFigureInfo {
        string Move();
        string Turn();
        string Scaling();
    }
    class Circle: IFigureInfo
    {
      double x, y, r;
        
        public Circle()
        {
            Console.WriteLine("Объект: Круг");
            Console.Write("Введите значение x="); this.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y="); this.y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение r="); this.r = Convert.ToDouble(Console.ReadLine());
        }
        public string Move()
        {
            Console.WriteLine("Введите координаты смещения круга");
            Console.Write("Смещение по x = "); double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Смещение по y = "); double dy = Convert.ToDouble(Console.ReadLine());
            this.x += dx;
            this.y += dy;
            return $"x={this.x} y={this.y} r={this.r}";
        }
        public string Turn()
        {
            Console.WriteLine("На сколько градусов вы бы хотели повернуть объект? ");
            Console.ReadLine();
            return $"x={this.x} y={this.y} r={this.r}"; 
        }
        public string Scaling()
        {
            Console.Write("Во сколько раз вы хотели бы увеличить размер данного объекта? "); double size = Convert.ToDouble(Console.ReadLine());
            this.r *= size;
            return $"x={this.x} y={this.y} r={this.r}";
        }
    }
    class Square: IFigureInfo
    {
        double ax, ay, cx, cy, r;
        public Square()
        {
            Console.WriteLine("Объект: Квадрат");
            Console.WriteLine("\nКоординаты центра:");
            Console.Write("cx="); this.cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("cy="); this.cy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вектор от r="); this.r = Convert.ToDouble(Console.ReadLine());
            this.ax = cx + r * Math.Cos(45 * Math.PI / 180);
            this.ay = cy + r * Math.Sin(45 * Math.PI / 180);
            Console.WriteLine($"ax={string.Format("{0:0.00}",this.ax)}"); 
            Console.WriteLine($"ay={string.Format("{0:0.00}", this.ay)}"); 
        }

        public string Move()
        {
            Console.WriteLine("Введите координаты смещения квадрата:");
            Console.Write("Смещение по x = "); double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Смещение по y = "); double dy = Convert.ToDouble(Console.ReadLine());
            this.cx += dx; this.ax += dx;
            this.cy += dy; this.ay += dy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
        public string Turn()
        {
            Console.Write("\nУгол поворота фигуры="); double grad = Convert.ToDouble(Console.ReadLine());
            double gradX, gradY;
            gradX = Convert.ToDouble((ax - cx) * Math.Cos(grad) - (ay - cy) * Math.Sin(grad));
            gradY = Convert.ToDouble((ax - cx) * Math.Sin(grad) + (ay - cy) * Math.Cos(grad));
            ax = gradX + cx;
            ay = gradY + cy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
        public string Scaling()
        {
            Console.Write("\nКоэффициент изменения расстояния до вершины квадрата="); double size = Convert.ToDouble(Console.ReadLine());
            ax = (ax - cx) * size + cx;
            ay = (ay - cy) * size + cy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
    }
    class Rectangle : IFigureInfo
    {
        double ax, ay, cx, cy, r;
        public Rectangle()
        {
            Console.WriteLine("Объект: Прямоугольник");
            Console.WriteLine("\nКоординаты центра:");
            Console.Write("cx="); this.cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("cy="); this.cy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вектор от r="); this.r = Convert.ToDouble(Console.ReadLine());
            this.ax = cx + r * Math.Cos(30 * Math.PI / 180);
            this.ay = cy + r * Math.Sin(30 * Math.PI / 180);
            Console.WriteLine($"ax={string.Format("{0:0.00}", this.ax)}");
            Console.WriteLine($"ay={string.Format("{0:0.00}", this.ay)}");
        }

        public string Move()
        {
            Console.WriteLine("Введите координаты смещения квадрата:");
            Console.Write("Смещение по x = "); double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Смещение по y = "); double dy = Convert.ToDouble(Console.ReadLine());
            this.cx += dx; this.ax += dx;
            this.cy += dy; this.ay += dy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
        public string Turn()
        {
            Console.Write("\nУгол поворота фигуры="); double grad = Convert.ToDouble(Console.ReadLine());
            double gradX, gradY;
            gradX = Convert.ToDouble((ax - cx) * Math.Cos(grad) - (ay - cy) * Math.Sin(grad));
            gradY = Convert.ToDouble((ax - cx) * Math.Sin(grad) + (ay - cy) * Math.Cos(grad));
            ax = gradX + cx;
            ay = gradY + cy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
        public string Scaling()
        {
            Console.Write("\nКоэффициент изменения расстояния до вершины квадрата="); double size = Convert.ToDouble(Console.ReadLine());
            ax = (ax - cx) * size + cx;
            ay = (ay - cy) * size + cy;
            return $"cx={this.cx} cy={this.cy} ax={string.Format("{0:0.00}", this.ax)} ay={string.Format("{0:0.00}", this.ay)}";
        }
    }
    class Program
    {
        static public void InfoAboutFigure(string obj, string fun)
        {
            Console.WriteLine($"\n\n\n         Параметры фигуры:\nОбъект: {obj}\nДанные: {fun,2:f3}\n\n\n");
        }
        static void Main(string[] args)
        {
            int command = 0;
            while ((command != 1) && (command != 2) && (command != 3) && (command != 4))
            {
                Console.WriteLine("Выберите необходимое действие: 1 - Круг, 2 - Квадрат, 3 - Прямоугольник, 4 - Выход");
                Console.Write("Вы выбрали:");
                command = Convert.ToInt32(Console.ReadLine());
            }
            switch (command)
            {
                case 1:
                    Circle Crug = new Circle();
                    InfoAboutFigure("Круг", Crug.Move());
                    InfoAboutFigure("Круг", Crug.Turn());
                    InfoAboutFigure("Круг", Crug.Scaling());
                    break;
                case 2:
                    Square kvadat = new Square();
                    InfoAboutFigure("Квадрат", kvadat.Move());
                    InfoAboutFigure("Квадрат", kvadat.Turn());
                    InfoAboutFigure("Квадрат", kvadat.Scaling());
                    break;
                case 3:
                    Rectangle rect = new Rectangle();
                    InfoAboutFigure("Прямоугольник", rect.Move());
                    InfoAboutFigure("Прямоугольник", rect.Turn());
                    InfoAboutFigure("Прямоугольник", rect.Scaling());
                    break;
                case 4: return;
            }
            Console.ReadKey();
        }
    }
}
