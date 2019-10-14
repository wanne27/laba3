using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    partial class Airline
    {
        private string destination = "";
        private int number = 0;
        private string type = "";
        private int time = 0;
        public enum weekDays
        {
            sun = 1, mon, thue, wen, thir, fri, sat
        }
        private weekDays wd = weekDays.mon;
        private readonly uint FlightID;
        private static int size = 0;
        public static void sizeinfo()
        {
            Console.WriteLine("Size:" + size);
        }

        public string DESTINATION
        {
            get { return this.destination; }
            set { this.destination = value; }

        }
        public int NUMBER
        {
            get { return this.number; }
            set { this.number = value; }

        }
        public string TYPE
        {
            get { return this.type; }
            set { this.type = value; }

        }
        public weekDays DAY
        {
            get { return this.wd; }
            set { this.wd = value; }

        }
        public uint ID
        {
            get{ return this.FlightID; }
                    
        }
        public Airline()
        {
            this.destination = "no";
            this.number = 0;
            this.type = "no";
            this.time = 0000;
            this.wd = weekDays.sun;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Конструктор без параметров!");

        }

        public Airline(string des, int n, string ty, int t, weekDays day)
        {
            this.destination = des;
            this.number = n;
            this.type = ty;
            this.time = t;
            this.wd = day;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Конструктор с параметрами!");
        }

        static Airline()
        {
            Console.WriteLine("Статический конструктор!");
        }
        public Airline(string des,int n, string ty)
        {
            this.destination = des;
            this.number = n;
            this.type = ty;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Просто конструктор!");
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            object[] ListOfFlights = new object[6]
            {
                 new Airline("Minsk", 2233,"Boing", 2345, Airline.weekDays.sat),
                 new Airline(),
                 new Airline("Minsk", 2233,"Boing", 2345, Airline.weekDays.sat),
                 new Airline("Kiev", 2323,"Air"),
                 new Airline("Minsk", 3233,"Boing", 1200,Airline.weekDays.mon),
                 new Airline("Vitebsk", 4148,"AurBus", 0030,Airline.weekDays.mon),
             };
            Airline.sizeinfo();
            Console.WriteLine("Список рейсов для Minsk:");
            foreach(Airline flight in ListOfFlights)
            {
                if (flight.DESTINATION == "Minsk")
                    Console.WriteLine(flight.NUMBER +"\t" + flight.TYPE +"\t"+ flight.DAY + "\t" + flight.ID);
            }
            Console.WriteLine("Список рейсов в понедельник:");
            foreach (Airline flight in ListOfFlights)
            {
                if (flight.DAY == Airline.weekDays.mon)
                    Console.WriteLine(flight.DESTINATION +"\t"+ flight.NUMBER + "\t" + flight.TYPE + "\t" + flight.ID);
            }
            var user = new { Name = "dddd" };
            Console.WriteLine(user.Name);
            Console.WriteLine(ListOfFlights[0].Equals(ListOfFlights[2]));
            Console.WriteLine(ListOfFlights[4].ToString());
            Console.ReadLine();
        }
    }
}
