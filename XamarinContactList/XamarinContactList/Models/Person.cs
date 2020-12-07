using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinContactList.Models
{
    public class Person
    {
        public Person(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
