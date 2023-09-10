using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class RegularPatient : Patient
    {
        public RegularPatient(string name,  string requestedDepartment)
            : base(name, requestedDepartment)
        {
        }

    }
}
