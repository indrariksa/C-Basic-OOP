using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP
{
    internal class FieldProperty
    {
    }

    class PropertyTest
    {
        public string materi2;
        private string materi;

        public string Materi
        {
            get { return materi; }
            set { materi = value; }
        }
    }

    class Person
    {
        private int nilai = 0;
        public int Nilai
        {
            get { return nilai; }
            set
            {
                if (value > 50)
                    nilai = value;
            }
        }
    }
}
