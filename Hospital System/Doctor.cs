using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class Doctor
    {
        private Specialization requestedSpecialization;

        public Specialization RequestedSpecialization
        {
            get { return requestedSpecialization; }
            set { requestedSpecialization = value; }
        }
        public void GetNewPatient()
        {
            if (this.requestedSpecialization.WatingUrgentPatients.Count != 0)
            {
                var patient = this.requestedSpecialization.WatingUrgentPatients.Dequeue();
                Console.WriteLine($"{patient.Name} please go with the doctor");
                this.requestedSpecialization.AvailableSpots++;
            }
            else if (this.requestedSpecialization.WatingRegularPatients.Count != 0)
            {
                var patient = this.requestedSpecialization.WatingRegularPatients.Dequeue();
                Console.WriteLine($"{patient.Name} please go with the doctor");
                this.requestedSpecialization.AvailableSpots++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Patient in {this.requestedSpecialization.Name} specialization right now");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
