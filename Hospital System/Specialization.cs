using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class Specialization
    {
        private const int MAXIMUM_SPOT_NUMBER = 5;

        public Specialization(string name)
        {
            Name = name;
            AvailableSpots = MAXIMUM_SPOT_NUMBER;
            Patients = new Queue<Patient>();
        }
        public string Name { get; }
        public int AvailableSpots { get; set; }
        public Queue<Patient> Patients { get; }

        public void Add(Patient patient)
        {
            if(AvailableSpots <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry this specialization is Full!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have been added in specialization according to your status");
                Patients.Enqueue(patient);
                AvailableSpots--;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void displayPatients()
        {
            PatientPrinter.Print(Patients);
        }

    }
}
