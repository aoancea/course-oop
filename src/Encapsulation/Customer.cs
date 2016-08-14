using System;

namespace Courses.OOP.Encapsulation
{
    public class Customer
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public Address ShippingAddress { get; set; }

        public DateTime DateOfBirth { get; set; }


        public int GetAge()
        {
            /*
			 * NOTE: this is not the correct way of calculating the age, its just for example purposes and to give an idea on encapsulating some logic inside a method
			 * For more information on how to really get the exact age of a person feel free to visit the SO website: http://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c
			 * FOR ADVANCED USERS: Consider encapsulating the calculus of the difference between two dates inside a service(method) and pass those to dates as a parameter. You can just call that service
			 * from here with the person's birthday and today's date. The logic inside need only to be concerned with calculating that difference, not that it can be somebody's age.
			 */

            return DateOfBirth != DateTime.MinValue ? DateTime.UtcNow.Subtract(DateOfBirth).Days / 365 : 0;
        }
    }
}