using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class Specialization
    {
        private string name;
        private int availableSpots;
        private Queue<Patient> watingRegularPatients;
        private Queue<Patient> watingUrgentPatients;

        public string Name
        {
            get { return name; }
        }
        public int AvailableSpots
        {
            get { return availableSpots; }
            set { availableSpots = value; }
        }
        public Queue<Patient> WatingRegularPatients
        {
            get { return watingRegularPatients; }
        }
        public Queue<Patient> WatingUrgentPatients
        {
            get { return watingUrgentPatients; }
        }
        public Specialization(string name)
        {
            this.name = name;
            this.availableSpots = 5;
            this.watingRegularPatients = new Queue<Patient>();
            this.watingUrgentPatients = new Queue<Patient>();
        }

        public void Add(Patient patient)
        {
            if(this.availableSpots <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry this specialization is Full!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have been added in specialization according to your status");
                if (patient.Status == 0)
                {
                    this.watingRegularPatients.Enqueue(patient);
                }
                else
                {
                    this.watingUrgentPatients.Enqueue(patient);
                }
                this.availableSpots--;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void displayPatients()
        {
            if (this.watingRegularPatients.Count != 0)
            {
                Console.WriteLine($"Patints that are in the {this.Name} specialization urgent list: ");
            }
            foreach (var p in watingRegularPatients)
            {
                Console.WriteLine($"Name: {p.Name}\tStatus: {(p.Status == 0 ? "regular" : "urgent")}");
            }
            Console.WriteLine();
            if(this.watingUrgentPatients.Count != 0)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Patints that are in the {this.Name} specialization urgent list: ");
            }
            foreach (var p in watingUrgentPatients)
            {
                Console.WriteLine($"Name: {p.Name}\tStatus: {(p.Status == 1 ? "urgent" : "regular")}");
            }
            Console.WriteLine();
        }

    }
}
