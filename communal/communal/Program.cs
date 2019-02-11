using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communal
{
    class Payment
    {
        public string address { get; set; }
        public Payment (string Address)
        {
            this.address = Address;
            Console.WriteLine($"Адрес квартиры: {address}");
        }
        public virtual void Plata(){}
    }
    class Heat : Payment
    {
        public double squareMetr { get; set; }
        public Heat(string Address, double squareMetr) :base(Address)
        {
            this.squareMetr = squareMetr;
            Console.WriteLine($"Площадь квартиры = {this.squareMetr} кв. м.");
        }
        public override void Plata()
        {
            Console.WriteLine($"Плата за отопление составляет {this.squareMetr*10} руб.");
        }
    }
    class Water : Payment
    {
        public int people { get; set; }
        public Water(string Address, int people) : base(Address)
        {
            this.people = people;
            Console.WriteLine($"Кол-во людей, проживающих в этой квартире = {this.people}");
        }
        public override void Plata()
        {
            Console.WriteLine($"Плата за воду составляет {this.people*100} руб.");
        }
    }
    class Electricity: Payment
    {
        public int kv { get; set; }
        public Electricity(string Address, int kv) : base(Address)
        {
            this.kv = kv;
            Console.WriteLine($"Кол-во киловатт = {this.kv}");
        }
        public override void Plata()
        {
            Console.WriteLine($"Плата за электричество составляет {this.kv } руб.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payment firstHeat = new Heat("Пушкина 23", 230);
            firstHeat.Plata();
            Payment secondHeat = new Heat("Гоголя 15", 534.5);
            secondHeat.Plata();
            
            Payment firstWater = new Water("Пушкина 23", 3);
            firstWater.Plata();
            Payment secondWater = new Water("Гоголя 15", 4);
            secondWater.Plata();
            Payment thirdWater = new Water("Баумана 30", 2);
            thirdWater.Plata();

            Payment firstElectricity = new Electricity("Пушкина 23", 180);
            firstElectricity.Plata();
            Payment secondElectricity = new Electricity("Гоголя 15", 220);
            secondElectricity.Plata();
            Payment thirdElectricityr = new Electricity("Баумана 30", 120);
            thirdElectricityr.Plata();
            Console.ReadKey();
        }
    }
}
