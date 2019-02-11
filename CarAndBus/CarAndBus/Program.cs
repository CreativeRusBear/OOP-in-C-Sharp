using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAndBus
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
            //Output();
        }
        public virtual void Move(double ed, double a)
        {
            this.r = a * Math.PI / 180;
            this.x = this.x + ed * Math.Cos(r);
            this.y = this.y + ed * Math.Sin(r);
            Output();
        }
        public virtual void Output()
        {
            Console.WriteLine($"x= {this.x,2:f2} y= {this.y,2:f2}");
        }
    }
    class tBus : tCar
    {
       // public string[] passengers { get; set; }
        public double money { get; set; }
        public double moneyPassengers { get; set; }
        public int capacity { get; set; }
        public int students { get; set; }
        public int simplePeople { get; set; }
        public tBus(double x, double y, int capacity) : base(x,y)
        {
            this.money = 0;
            this.capacity = capacity;
            this.students = 0;
            this.simplePeople = 0;
            //this.passengers = new string[capacity];
        }
        public override void Move(double ed, double a)
        {
            this.r = a * Math.PI / 180;
            this.x = this.x + ed * Math.Cos(r);
            this.y = this.y + ed * Math.Sin(r);
            this.money += this.students * ed*1.25 + this.simplePeople*ed*2;
            this.Output();
            
        }
        public override void Output()
        {
            Console.WriteLine($"x= {this.x,2:f2} y= {this.y,2:f2}\nКол-во пассажиров: студентов: {this.students}, обычных людей: {this.simplePeople}\nКол-во полученных денег: {this.money,6:f2}\nКол-во свободных мест: {this.capacity-this.students-this.simplePeople}");
        }
        public void Input(int people, int stud)
        {
            if (this.students + this.simplePeople + people + stud <= this.capacity)
            {
                Console.WriteLine($"Вошло {stud} студентов и {people} обычных людей");
                this.students += stud;
                this.simplePeople += people;    
            }
            else Console.WriteLine("Недостаточно мест в автобусе");
            /* if (this.passengers.Length + people <= this.capacity)
             {
                 for (int i = 0; i < people; i++)
                 {
                     Console.Write($"Выберите тип {i + 1}-го вошедшего пассажира: 1-обычный 2-студент ");
                     int type = Convert.ToInt32(Console.ReadLine());
                     int countOfArr = this.passengers.Length;
                     switch (type)
                     {
                         case 1:
                             this.passengers[countOfArr] = "обычный";
                             break;
                         case 2:
                             this.passengers[countOfArr] = "студент";
                             break;
                     }
                 }
                 this.Output();
             }
             else
             {
                 Console.Write("Недостаточно мест в автобусе");
             }*/
        }

        public void Exit(int people, int stud)
        {
            if (this.students+this.simplePeople-people-stud > 0) {
                this.students -= stud;
                this.simplePeople -= people;
                Console.WriteLine($"Вышло {stud} студентов и {people} обычных людей");
            } else Console.WriteLine("Количество человек в автобусе меньше, чем то значение, которое вы передаете в параметре");
            //int kolvo = this.passengers.Length;
            //if (this.passengers.Length - people > 0)
            //{
            // for (int i = 0; i < people; i++)
            //{
            //int []indexes = { kolvo - i };
            //this.passengers[50].Remove(3);
            //this.passengers = (from x in chels where !(from y in indexes select this.passengers.ElementAt(y)).Contains(x) select x).ToArray();
            //  }
            // this.Output();
            // }else
            // {
            //     Console.Write("Количество человек в автобусе меньше, чем то значение, которое вы передаете в параметре");
            //}
          }
        }

    class Program
    {
        static void Main(string[] args)
        {
            tBus Bus = new tBus(0, 0, 50);
            Bus.Input(2,5);
            Bus.Move(20, 45);
            Bus.Exit(5,2);
            Bus.Exit(1,1);
            Bus.Move(20, 135);
            Bus.Input(3, 1);
            Bus.Move(20, 225);
            Bus.Input(1, 1);
            Bus.Move(20, 315);
            Console.ReadKey();
        }
    }
}
