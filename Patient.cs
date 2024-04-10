using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_project
{
    internal class Patient
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public TreatmentPlan TreatmentPlan { get; set; }

    }
}
