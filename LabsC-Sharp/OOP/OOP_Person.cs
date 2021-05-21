using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp.OOP
{
    class OOP_Person
    {
        public OOP_Person(DateTime birthDate, string name)
        {
            BirthDate = birthDate;
            Name = name;
        }

        public void ChangeAddress(string streetAddress, int postcode, string city)
        {
            StreetAddress = streetAddress;
            Postcode = postcode;
            City = city;
        }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public int Postcode { get; private set; }
        public string City { get; private set; }
    }
}
