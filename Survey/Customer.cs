using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    enum Gender
    {
        Male,
        Female
    }
    
    class Customer
    {

        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string FatherName{ get; set; }
        public string Country{ get; set; }
        public string City{ get; set; }
        public string Phone{ get; set; }

        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }
       

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nFather Name: {FatherName}\nCountry: {Country}\nCity: {City}\nPhone: {Phone}\nBirthday: {BirthDay.ToShortDateString()}\nGender: {Gender}";
        }

    }
}
