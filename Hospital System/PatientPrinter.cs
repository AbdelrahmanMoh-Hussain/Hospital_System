using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class PatientPrinter
    {
        public static void Print(Queue<Patient> patients)
        {
            foreach (var p in patients)
            {
                Console.WriteLine($"Name: {p.Name}\tStatus: {p.GetType().Name}\tDepartment: {p.RequestedDepartment}");
            }
            Console.WriteLine();
        }
    }
}
