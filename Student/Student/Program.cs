using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Colledge
    {
        public string surname,name;
        public int ocenka,stipendia;

        public void lod()
        {
            Console.WriteLine("Фамилия: "+ this.surname + "\nИмя"+this.name+ "\nОценка: "+this.ocenka.ToString()+"\nСтипендия: "+this.stipendia.ToString());
        }

        public void cold()
        {
            Console.Write("Введите фамилию: "); this.surname = Console.ReadLine();
            Console.Write("Введите имя: "); this.name = Console.ReadLine();
            Console.Write("Введите оценку: "); this.ocenka = Convert.ToInt32(Console.ReadLine());
            if (this.ocenka >= 4)
            {
                Console.Write("Введите стипендию: "); this.stipendia = Convert.ToInt32(Console.ReadLine());
            }
            else
                Console.WriteLine("Так как оценка ниже 4, стипендия не положена");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "да";
            int n;
            Colledge s;
            List<Colledge> sa = new List<Colledge>();
            Console.WriteLine("\n\n\n\n\n\nПрограмма студент");
            Console.WriteLine("\nВыполнил студент 157 групппы Гусев Артем");
            Console.Write("Введите кол-во студентов: ");
            n = int.Parse(Console.ReadLine());
            Console.Clear();
            sa.Clear();
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Ввод студентов");
                Console.WriteLine("Ввод " + (i + 1).ToString() + "-го студента");
                s = new Colledge();
                s.cold();
                sa.Add(s);
                Console.Clear();
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Выввод студентов, сдавших на 4/5");
            for (int i=0; i < n; i++)
            {
                if (sa[i].ocenka >= 4)
                {
                    Console.WriteLine("Вывод " + (i + 1).ToString() + "-го студента");
                    sa[i].lod();
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
            Console.WriteLine("\nПовторить решение (да/нет)");
            str = Console.ReadLine();
        }
    }
}
