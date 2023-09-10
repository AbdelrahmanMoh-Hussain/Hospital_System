using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital_System
{
    public class Patient
    {

        public Patient(string name,string requestedDepartment)
        {
            Name = name;
            RequestedDepartment = requestedDepartment;
        }

        public string Name { get; private set; }
        public string RequestedDepartment { get; private set; }
    }
}
