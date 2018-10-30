using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Coordinates p1;
            p1.x = 1;
            p1.y = 2;
            p1.z = 3;          

            double x1, x2, x3;            
            (x1, x2, x3) = p1;
            double len = Math.Sqrt(x1 * x1 + x2 * x2 + x3 * x3);
            //Task2
            Console.WriteLine(len);
            

            var now = DateTime.Now;
            var (year, month, day, hours, minutes, seconds) = now;
            //Console.WriteLine(now.ToString("yyyy.MM.dd hh:mm:ss")); 
            Console.WriteLine("{0}.{1}.{2} {3}:{4}:{5}", year, month, day, hours, minutes, seconds);

        }
    }

    struct Coordinates
    {
        public double x;
        public double y;
        public double z;

        public void Deconstruct(out double x, out double y, out double z)
        {
            x = this.x;
            y = this.y;
            z = this.z;
        }
    }

    public static class DateTimeExtensions
    {
        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hours, out int minutes, out int seconds)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
            hours = dateTime.Hour;
            minutes = dateTime.Minute;
            seconds = dateTime.Second;
        }
    }

}
