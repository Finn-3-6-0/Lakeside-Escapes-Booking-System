using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaksideEscapesBookingSystem.Models
{
    class Guests
    {
        public string GuestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PreviouslyBooked { get; set; }

        public Guests(string guestID, string firstName, string lastName, string email, string phoneNumber, string title, string addressLine1, string addressLine2, string previouslyBooked)
        {
            GuestID = guestID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Title = title;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PreviouslyBooked = previouslyBooked;
        }

        public Guests()
        {

        }

    }
}
