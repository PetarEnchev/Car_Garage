using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Garage
{
    public class Mechanic
    {
        private string mechanicId;
        private string fullName;
        private string specialization;

        public Mechanic(string mechanicId, string fullName, string specialization)
        {
            MechanicId = mechanicId;
            FullName = fullName;
            Specialization = specialization;
        }

        public string MechanicId
        {
            get { return mechanicId; }
            set { mechanicId = value; }
        }


        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
    }
}
