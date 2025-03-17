using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_class_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "jono";
            taxi.OnDuty = "Yes";
            taxi.NumPassenger = 10;

            taxi.Registrasi();
            taxi.Isipenumpang();

            Console.ReadKey();
        }
    }
}
