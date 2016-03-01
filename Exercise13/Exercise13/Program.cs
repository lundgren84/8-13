using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        public static void GetAge(DateTime a)
        {
            int c = 0;
            int b = a.Year;
            while (b < DateTime.Now.Year)
            {
                b++;
                c++;
            }
            if (a.Month > DateTime.Now.Month)
            {
                c--;
            }
            else if (a.Month == DateTime.Now.Month)
            {
                if (a.Day > DateTime.Now.Day) { c--; }
            }
            Console.WriteLine("You are "+c+" years old");
        }
        public static void ToNextBirthDay(DateTime a)

        {
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, a.Month, a.Day);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;
            Console.WriteLine("Days to next B-Day: "+numDays);
        }
        public static void DayOn100(DateTime a)
        {
            DateTime Future = new DateTime(a.Year+100,a.Month,a.Day);
            
            Console.WriteLine($"Your 100th bierthday will be on a {Future.DayOfWeek} At date: {Future.ToLongDateString()}");
        }
        static void Main(string[] args)
        {


            int year = 0;
            int month = 0;
            int day = 0;
            string a = string.Empty;
            string b = string.Empty;

            Console.WriteLine("Write your firstName");
            a = Console.ReadLine();
            Console.WriteLine("Write your lastName");
            b = Console.ReadLine();

            Console.WriteLine("Write year");
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("Write mounth");
            int.TryParse(Console.ReadLine(), out month);
            Console.WriteLine("Write day");
            int.TryParse(Console.ReadLine(), out day);

            DateTime personDate = new DateTime(year, month, day);



            Console.WriteLine($"Hi {a} {b}");
            GetAge(personDate);
            ToNextBirthDay(personDate);
            DayOn100(personDate);


            Console.WriteLine("\n\nCurrent date: "+DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
