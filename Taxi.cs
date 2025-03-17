using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tugas_class_taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("DriveName: {0}", DriverName);
            Console.WriteLine("OnDuty: {0}", OnDuty);
            Console.WriteLine("NumPassenger: {0}", NumPassenger);
            Console.WriteLine("\nsedang menjemput penumpang");
        }

        public void Isipenumpang()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
