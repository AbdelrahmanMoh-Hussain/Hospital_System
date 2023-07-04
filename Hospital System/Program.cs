namespace Hospital_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hospital System");
            Dictionary<string, Specialization> specializations = new Dictionary<string, Specialization>();
            specializations.Add("Children", new Specialization("Children"));
            specializations.Add("Surgery", new Specialization("Surgery"));
            specializations.Add("Heart", new Specialization("Heart"));
            specializations.Add("Brain", new Specialization("Brain"));
            specializations.Add("Psyco", new Specialization("Psyco"));

            while (true)
            {
                Console.WriteLine("If you are a Doctor press 1\nIf you are a Patient press 2\nPress 3 to EXIT");
                var keyPressed = Console.ReadLine();
                if (keyPressed == "1")
                {
                    Console.WriteLine("Hello, Doctor ");
                    Console.Write("Enter specialization: ");
                    var doctorSpecialization = Console.ReadLine();
                    Doctor doctor = new Doctor();
                    doctor.RequestedSpecialization = specializations[doctorSpecialization];
                    doctor.GetNewPatient();
                }
                else if (keyPressed == "2")
                {
                    Console.WriteLine("Hello, Patient");
                    Console.WriteLine("Enter your info: ");
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Status: ");
                    var status = int.Parse(Console.ReadLine());
                    Console.Write("Requested specialization: ");
                    var requestedSpecialization = Console.ReadLine();
                    Patient patient = new Patient(name, status, requestedSpecialization);

                    specializations[patient.RequestedSpecialization].Add(patient);
                    specializations[patient.RequestedSpecialization].displayPatients();
                }
                else
                    break;
            }
        }
    }
}