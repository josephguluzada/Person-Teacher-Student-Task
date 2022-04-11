using System;
using System.Collections.Generic;
using System.Text;

namespace PST.Models
{
    class Teacher : Person
    {
        private int _experience;
        private static int _id;


        public int Id { get;}
        public int Experience
        {
            get => _experience;
            set 
            {
                if (value > 0 && value <= 80) _experience = value;
            }
        }

        public Teacher(int experience)
        {
            _id++;
            Id = _id;
            Experience = experience;
        }

    }
}
