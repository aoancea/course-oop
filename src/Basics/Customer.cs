using System;

namespace Courses.OOP.Basics
{
    public class Customer
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string ShipppingAddress { get; set; }

        public DateTime DateOfBirth { get; set; }


        public int GetAge() { throw new NotImplementedException(); }
    }
}