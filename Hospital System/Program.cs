﻿namespace Hospital_System
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
                    Doctor doctor = new Doctor(specializations[doctorSpecialization]);
                    doctor.GetNewPatient();
                }
                else if (keyPressed == "2")
                {
                    Console.WriteLine("Hello, Patient");
                    Console.WriteLine("Enter your info: ");
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Status(0 for Regular - 1 for Urgent): ");
                    var status = (Console.ReadLine() == "0" ? PatientStatus.Regular : PatientStatus.Urgent);
                    Console.Write("Requested department: ");
                    var requestedDepartment = Console.ReadLine();

                    Patient patient;
                    switch (status)
                    {
                        case PatientStatus.Regular:
                            patient = new RegularPatient(name, requestedDepartment);
                            break;
                        case PatientStatus.Urgent:
                            patient = new UrgentPatient(name, requestedDepartment);
                            break;
                        default:
                            patient = new RegularPatient(name, requestedDepartment);
                            break;
                    }

                    specializations[patient.RequestedDepartment].Add(patient);
                    specializations[patient.RequestedDepartment].displayPatients();
                }
                else
                    break;
            }
        }
    }
}