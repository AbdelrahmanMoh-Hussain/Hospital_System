using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class Doctor
    {
        public Doctor(Specialization requestedSpecialization)
        {
            RequestedSpecialization = requestedSpecialization;
        }

        public Specialization RequestedSpecialization { get; private set; }

        public void GetNewPatient()
        {
            if (RequestedSpecialization.Patients.Count != 0)
            {
                var patient = RequestedSpecialization.Patients.Dequeue();
                Console.WriteLine($"{patient.Name} please go with the doctor");
                RequestedSpecialization.AvailableSpots++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Patient in {RequestedSpecialization.Name} specialization right now");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
