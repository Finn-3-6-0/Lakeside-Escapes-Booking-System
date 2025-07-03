using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaksideEscapesBookingSystem.Models
{
    class Bookings
    {
        public int BookingID { get; set; }
        public string GuestID { get; set; }
        public int PodID { get; set; }
        public int CourseID { get; set; }
        public int NumberOfOccupants { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string BookingStatus { get; set; }
        public int DepositAmount { get; set; }
        public int DiscountPercentage { get; set; }
        public int TotalAmount { get; set; }
        public DateTime DateBooked { get; set; }

        public Bookings(string guestID, int podID, int courseID, int numberOfOccupants, DateTime checkInDate, DateTime checkOutDate, string bookingStatus, int depositAmount, int discountPercentage, int totalAmount, DateTime dateBooked)
        {
            GuestID = guestID;
            PodID = podID;
            CourseID = courseID;
            NumberOfOccupants = numberOfOccupants;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            BookingStatus = bookingStatus;
            DepositAmount = depositAmount;
            DiscountPercentage = discountPercentage;
            TotalAmount = totalAmount;
            DateBooked = dateBooked;
        }
        public Bookings()
        {

        }
    }
}

