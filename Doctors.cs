using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_project
{
    internal class Doctors
    {
        public class Doctor
        {
            public void Treat()
            {
                Console.WriteLine("Give a perscription");
            }
        }

        public class Surgeon : Doctor, ITreat
        {
            public void Treat() 
            {
                Console.WriteLine("Surgery");
            }
        }

        public class Physician : Doctor, ITreat
        {
            public void Treat()
            {
                Console.WriteLine("Take pills");
            }
        }

        public class Dentist : Doctor, ITreat
        {
            public void Treat()
            {
                Console.WriteLine("Remove a tooth");
            }
        }
    }
    public interface ITreat
    {
        void Treat();
    }
}
