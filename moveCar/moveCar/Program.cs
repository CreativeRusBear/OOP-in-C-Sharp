using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveCar
{
    class tCar
    {
        public double x { get; set; }
        public double y { get; set; }
        public double r { get; set; }
        public tCar(double x, double y)
        {
            this.x = x;
            this.y = y;
            Output();
        }
        public void Move(double ed, double a)
        {
            this.r = a * Math.PI / 180;
            this.x = this.x + ed * Math.Cos(r);
            this.y = this.y + ed * Math.Sin(r);
            Output();  
        }
        public void Output()
        {
            Console.WriteLine($"x= {this.x,2:f2} y= {this.y,2:f2}");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            tCar Machine = new tCar(0, 0);
            Machine.Move(20, 45);
            Machine.Move(20, 135);
            Machine.Move(20, 225);
            Machine.Move(20, 315);
            Console.ReadKey();
        }
    }
}
