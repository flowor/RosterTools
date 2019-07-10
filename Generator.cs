using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterTools
{

    class Generator
    {
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

        private Entry getRandomEntry()
        {
            return new Entry();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
