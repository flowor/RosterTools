using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterTools
{
    class Entry
    {
        public enum Gender
        {
            Male = 'm',
            Female = 'f',
        }

        public enum Room
        {
            A,
            B,
            C,
            D,
        }

        private string _fname;
        private string _lname;
        private Gender _sex;
        private string _apt;
        private Room _rm;

        public string fname {
            get { return _fname; }
            set { _fname = value; }
        }

        public string lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public Gender sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string apt
        {
            get { return _apt; }
            set { _apt = value; }
        }

        public Room rm
        {
            get { return _rm; }
            set { _rm = value; }
        }

        public string booking
        {
            get { return string.Format("{0}-{1}", apt, rm.ToString()); }
            private set { }
        }

        public string fullName
        {
            get { return string.Format("{0} {1}", fname, lname); }
            private set { }
        }

        public string email
        {
            get
            {
                Random rnd = new Random();
                int rand = rnd.Next(0, 100);

                // 10% chance
                if (rand < 10)
                {
                    rand = rnd.Next(2, 4);
                    return string.Format("{0} {1}{2}{3}@umassd.edu", fname.Substring(0, 1), lname, rand);
                }
                return string.Format("{0} {1}{2}@umassd.edu", fname.Substring(0, 1), lname);
            }

            private set { }
        }



    }
}
