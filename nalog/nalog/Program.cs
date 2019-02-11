using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nalog
{
    class Property
    {
        public double worth { get; set; }
        public string address { get; set; }
        public Property(double Worth, string Address)
        {
            this.worth = Convert.ToDouble(Worth);
            this.address = Address;
            //Console.WriteLine($"Стоимость: {this.worth}\nАдрес: {this.address}");
        }
        public virtual void Raschet_naloga() { }
    }
    class Appartment : Property
    {
        public Appartment(double Worth, string Address) : base( Worth, Address)
        {
           
        }
        public override void Raschet_naloga()
        {
            Console.WriteLine($"Налог на квартиру {this.address} составляет  {this.worth * 1/1000} руб.");
        }
    }
    class Car : Property
    {
        public Car(double Worth, string Address) : base( Worth, Address)
        {

        }
        public override void Raschet_naloga()
        {
            Console.WriteLine($"({this.address}) Налог на машину составляет {this.worth * 1 / 200} руб.");
        }
    }
    class CountryHouse : Property
    {
        public CountryHouse(double Worth, string Address) : base( Worth, Address)
        {

        }
        public override void Raschet_naloga()
        {
            Console.WriteLine($"({this.address}) Налог на дачу составляет {this.worth * 1 / 500} руб.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Property[] array = new Property[7];
            array[0] = new Appartment(2300000, "ул. Ленина 46 кв. 59");
            array[1] = new Appartment(1300000, "ул. Ленина 43 кв. 51");
            array[2] = new Appartment(1900000, "ул. Катина 132");

            array[3] = new Car(1300000, "ул. Ленина 43 кв. 51");
            array[4] = new Car(1900000, "ул. Катина 132");

            array[5] = new CountryHouse(1300000, "ул. Ленина 43 кв. 51");
            array[6] = new CountryHouse(1900000, "ул. Катина 132");

            for (int i=0; i <array.Length; i++)
            {
                array[i].Raschet_naloga();
            }
            Console.ReadKey();
        }
    }
}
