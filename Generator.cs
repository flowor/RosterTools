using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterTools
{
    class Generator
    {
        private const string maleNames = @"first_male.txt";
        private const string femaleNames = @"first_female.txt";
        private const string lastNames = @"last.txt";

        public enum Headers
        {
            NameLast,
            NameFirst,
            FriendlyName,
            StudentNumber,
            RoomLocationDescription,
            Bedspace,
            Email,
            GenderAbbreviation,
            DateofBirth,
            Age
        }

        private string filename;
        private Headers[] headers;

        public Generator(string filename, Headers[] headers)
        {
            this.filename = filename;
            this.headers = headers;
        }

        public Generator(Headers[] headers)
        {
            this.headers = headers;
        }


        public void Write()
        {

        }

        public Entry CreateRandomEntry(string apt, Entry.Room rm, int minAge = 18, int maxAge = 23)
        {
            Entry randEntry = new Entry();

            Random rnd = new Random();
            int rand = rnd.Next(0, 2);
            string[] fnames;

            // Randomly create a male or female
            switch (rand)
            {

                // Male
                case 0:
                    randEntry.sex = Entry.Gender.Male;
                    fnames = FileToArray(maleNames);
                    randEntry.fname = fnames[rnd.Next(0, fnames.Length)];
                    break;

                // Female
                case 1:
                    randEntry.sex = Entry.Gender.Female;
                    fnames = FileToArray(femaleNames);
                    randEntry.fname = fnames[rnd.Next(0, fnames.Length)];
                    break;

            }

            string[] lnames = FileToArray(lastNames);
            randEntry.lname = lnames[rnd.Next(0, lnames.Length)];

            randEntry.apt = apt;
            randEntry.rm = rm;


            return randEntry;
        }

        private string[] FileToArray(string path)
        {
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(path);
            return lines.ToArray();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
