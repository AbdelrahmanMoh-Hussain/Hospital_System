using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class Patient
    {
        private string name;
        private int status;
        private string requestedSpecialization;

        public Patient(string name, int status, string requestedSpecialization)
        {
            this.name = name;
            this.status = status;
            this.requestedSpecialization = requestedSpecialization;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public string RequestedSpecialization
        {
            get { return requestedSpecialization; }
            set { requestedSpecialization = value; }
        }
    }
}
