using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz19._04._2023 {
    public class Passenger {
        public string Surname { get; set; }
        public int BagQuan { get; set; }
        public int BagWeight { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int FlightHours { get; set; }
        public string Destination { get; set; }
        public string FlightName { get; set; }
        public Passenger() : this(null, 0, 0, null, null, 0, null, null) { }
        public Passenger(string surname, int bagQuan, int bagWeight,
            string date, string time, int flightHours, string destination, string name) {
            Surname = surname;
            BagQuan = bagQuan;
            BagWeight = bagWeight;
            Date = date;
            Time = time;
            FlightHours = flightHours;
            Destination = destination;
            FlightName = name;
        }
    }
    public class Airport {
        public List<Passenger> passengers = new List<Passenger>();
        public Airport() => passengers = null;
        public Airport(List<Passenger> list, string name) {
            foreach (Passenger passenger in list) passengers.Add(passenger);
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
