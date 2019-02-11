using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Circle
    {
        private double x, y, r;
        public double Size
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0) r *= value;
                else { Console.Write("Ошибка! Во сколько раз вы хотели бы увеличить размер данного объекта?"); Size = Convert.ToDouble(Console.ReadLine()); }
            }
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                /*if ((value > 0) && (x - value >= 0) && (y - value >= 0))*/
                if (value > 0) r = value;
                else { Console.Write("Ошибка! Введите значение r="); R = Convert.ToDouble(Console.ReadLine()); }
            }
        }
        public Circle()
        {
            Console.Write("Введите значение x="); this.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y="); this.y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение r="); this.R = Convert.ToDouble(Console.ReadLine());
            this.GetInfo();
            this.actionChoice();
        }
        public void actionChoice()
        {
            int action = 0;
            while ((action != 1) && (action != 2) && (action != 3) && (action != 4))
            {
                Console.WriteLine("Выберите необходимое действие для объекта \"круг\": 1 - Переместить, 2 - Изменить размер, 3 - Повернуть объект, 4 - Завершить работу");
                Console.Write("Вы выбрали:");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        this.Move();
                        break;
                    case 2:
                        this.Scaling();
                        break;
                    case 3:
                        this.Turn();
                        break;
                    case 4: return; 
                }
            }

        }
        public void Move()
        {
            Console.Write("Введите необходимое значение для пермещения по x="); this.x += Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите необходимое значение для перемещения по y="); this.y += Convert.ToDouble(Console.ReadLine());
            this.GetInfo();
            this.actionChoice();
        }

        public void Scaling()
        {
            Console.Write("Во сколько раз вы хотели бы увеличить размер данного объекта? "); this.Size = Convert.ToDouble(Console.ReadLine());
            this.GetInfo();
            this.actionChoice();
        }

        public void Turn()
        {
            Console.WriteLine("На сколько градусов вы бы хотели повернуть объект? ");Console.ReadLine();
            this.GetInfo();
            this.actionChoice();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Объект: Круг. x={x} y={y} r={r}");
        }
    }
    class Square
    {
        public double ax, ay,cx,cy;
        public double grad;
        private double Grad
        {
            get
            {
                return grad;
            }
            set
            {
                if (value >= 0) grad=value * Math.PI / 180;
                else { Console.Write("Ошибка! Значение градусов не может быть отрицательным. Повторите попытку."); Grad= Convert.ToDouble(Console.ReadLine()); }
            }
        }
        private double AX
        {
            get
            {
                return ax;
            }
            set
            {
                if (value != cx) ax= value;
                else
                {
                    Console.Write("Ошибка! Повторите попытку."); AX = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private double AY
        {
            get
            {
                return ay;
            }
            set
            {
                if (value != cy) ay = value;
                else
                {
                    Console.Write("Ошибка! Повторите попытку."); AY = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        public Square()
        {
            Console.WriteLine("\nКоординаты центра:");
            Console.Write("cx="); this.cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("cy="); this.cy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вектор от центра до вершины:");
            Console.Write("ax="); this.AX = Convert.ToDouble(Console.ReadLine());
            Console.Write("ay="); this.AY = Convert.ToDouble(Console.ReadLine());
            this.GetInfo();
            this.actionChoice();
        }
        public void actionChoice()
        {
            int action = 0;
            while ((action != 1) && (action != 2) && (action != 3) && (action != 4))
            {
                Console.WriteLine("Выберите необходимое действие для объекта \"квадрат\": 1 - Переместить, 2 - Изменить размер, 3 - Повернуть объект, 4 - Завершить работу");
                Console.Write("Вы выбрали:");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        this.Move();
                        break;
                    case 2:
                        this.Scaling();
                        break;
                    case 3:
                        this.Turn();
                        break;
                    case 4: return;
                }
            }

        }
        public void Move()
        {
            Console.WriteLine("\nВведите координаты смещения фигуры:");
            Console.Write("Смещение по X= "); double x = Convert.ToDouble(Console.ReadLine());                    
            Console.Write("Смещение по Y= "); double y = Convert.ToDouble(Console.ReadLine());
            ax += x;
            cx += x;
            ay += y;
            cy += y;
            this.GetInfo();
            this.actionChoice();
        }

        public void Scaling()
        {
            Console.Write("\nКоэффициент изменения расстояния до вершины квадрата="); double size = Convert.ToDouble(Console.ReadLine());
            ax = (ax - cx) * size + cx;
            ay = (ay - cy) * size + cy;
            this.GetInfo();
            this.actionChoice();
        }

        public void Turn()
        {
            Console.Write("\nУгол поворота фигуры="); Grad = Convert.ToDouble(Console.ReadLine());
            
            double gradX, gradY;
            gradX = Convert.ToDouble((ax - cx) * Math.Cos(grad) - (ay - cy) * Math.Sin(grad));
            gradY = Convert.ToDouble((ax - cx) * Math.Sin(grad) + (ay - cy) * Math.Cos(grad));
            ax= gradX + cx;
            ay= gradY + cy;
            this.GetInfo();
            this.actionChoice();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Объект: Квадрат, имеющий координаты:\nЦентра: ({cx,6:f3};{cy,6:f3})\nВектор от центра до вершины: ({ax,6:f3};{ay,6:f3})");
        }
    }
    class Rectangle
    {
        public double aX, aY, bX, bY, cX, cY, dX, dY, centerX, centerY, grad, h;
        private double BY
        {
            get
            {
                return bY;
            }
            set
            {
                if (value == aY) bY = value;
                else
                {
                    Console.Write("Ошибка! Повторите попытку."); BY = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private double Grad
        {
            get
            {
                return grad;
            }
            set
            {
                if (value >= 0) grad = value * Math.PI / 180;
                else { Console.Write("Ошибка! Значение градусов не может быть отрицательным. Повторите попытку."); Grad = Convert.ToDouble(Console.ReadLine()); }
            }
        }
        public double Height
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0) h = value;
                else { Console.Write("Ошибка! Введите значение h="); Height = Convert.ToDouble(Console.ReadLine()); }
            }
        }
        public Rectangle()
        {
            Console.WriteLine("\nТочка A (левая верхняя):");
            Console.Write("x="); this.aX = Convert.ToDouble(Console.ReadLine());
            Console.Write("y="); this.aY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nТочка B (правая верхняя):");
            Console.Write("x="); this.bX = Convert.ToDouble(Console.ReadLine());
            Console.Write("y="); this.BY = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nДлина прямоугольника=");this.Height = Convert.ToDouble(Console.ReadLine());

            
            this.cX = bX;
            this.cY = bY + h;

            this.dX = aX;
            this.dY = aY + h;

            centerX = (bX - aX) / 2 + aX;
            centerY = (dY - aY) / 2 + aY;

            this.GetInfo();
            this.actionChoice();
        }
        public void actionChoice()
        {
            int action = 0;
            while ((action != 1) && (action != 2) && (action != 3) && (action != 4))
            {
                Console.WriteLine("Выберите необходимое действие для объекта \"Прямоугольник\": 1 - Переместить, 2 - Изменить размер, 3 - Повернуть объект, 4 - Завершить работу");
                Console.Write("Вы выбрали:");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        this.Move();
                        break;
                    case 2:
                        this.Scaling();
                        break;
                    case 3:
                        this.Turn();
                        break;
                    case 4: return;
                }
            }

        }
        public void Move()
        {
            Console.WriteLine("\nВведите координаты смещения фигуры:");
            Console.Write("Смещение по X= "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Смещение по Y= "); double y = Convert.ToDouble(Console.ReadLine());
            aX += x;
            aY += y;
            bX += x;
            bY += y;
            cX += x;
            cY += y;
            centerX += x;
            centerY += y;

            this.GetInfo();
            this.actionChoice();
        }

        public void Scaling()
        {
            Console.Write("\nКоэффициент изменения расстояния до вершины квадрата="); double size = Convert.ToDouble(Console.ReadLine());
            aX = (aX - centerX) * size + centerX;
            aY = (aY - centerY) * size + centerY;

            bX = (bX - centerX) * size + centerX;
            bY = (bY - centerY) * size + centerY;

            cX = (cX - centerX) * size + centerX;
            cY = (cY - centerY) * size + centerY;

            dX = (dX - centerX) * size + centerX;
            dY = (dY - centerY) * size + centerY;
            this.GetInfo();
            this.actionChoice();
        }

        public void Turn()
        {
            Console.Write("\nУгол поворота фигуры="); Grad = Convert.ToDouble(Console.ReadLine());
            double gradX, gradY;
            gradX = Convert.ToDouble((aX - centerX) * Math.Cos(grad) - (aY - centerY) * Math.Sin(grad));
            gradY = Convert.ToDouble((aX - centerX) * Math.Sin(grad) + (aY - centerY) * Math.Cos(grad));
            aX = gradX + centerX;
            aY = gradY + centerY;

            gradX = Convert.ToDouble((bX - centerX) * Math.Cos(grad) - (bY - centerY) * Math.Sin(grad));
            gradY = Convert.ToDouble((bX - centerX) * Math.Sin(grad) + (bY - centerY) * Math.Cos(grad));
            bX = gradX + centerX;
            bY = gradY + centerY;

            gradX = Convert.ToDouble((cX - centerX) * Math.Cos(grad) - (cY - centerY) * Math.Sin(grad));
            gradY = Convert.ToDouble((cX - centerX) * Math.Sin(grad) + (cY - centerY) * Math.Cos(grad));
            cX = gradX + centerX;
            cY = gradY + centerY;

            gradX = Convert.ToDouble((dX - centerX) * Math.Cos(grad) - (dY - centerY) * Math.Sin(grad));
            gradY = Convert.ToDouble((dX - centerX) * Math.Sin(grad) + (dY - centerY) * Math.Cos(grad));
            dX = gradX + centerX;
            dY = gradY + centerY;

            this.GetInfo();
            this.actionChoice();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Объект: Прямоугольник, имеющий координаты:\nЦентра: ({centerX};{centerY})\nA: ({aX,6:f3};{aY,6:f3})\nB: ({bX,6:f3};{bY,6:f3})\nC: ({cX,6:f3};{cY,6:f3})\nD: ({dX,6:f3};{dY,6:f3})");
        }
    }
    class Program
    {
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
                    break;
                case 2:
                    Square Kvadrat = new Square();
                    break;
                case 3:
                    Rectangle Priamougolnik = new Rectangle();
                    break;
                case 4: return;
            }
        }
    }
}
