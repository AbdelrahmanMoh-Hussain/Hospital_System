using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class UrgentPatient : Patient
    {
        public UrgentPatient(string name,  string requestedDepartment) 
            : base(name, requestedDepartment)
        {
        }
    }
}
