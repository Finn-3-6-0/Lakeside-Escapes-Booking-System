using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaksideEscapesBookingSystem
{
    class ValidationClass
    {

        public static bool bookedInAdvance(DateTime dateWanted, DateTime dateWanted2)
        {
            DateTime currentDate = DateTime.Now;

            // Check if the date is within the prohibited period (20th December to 20th January)
            if (((dateWanted.Month == 12 && dateWanted.Day >= 20) ||
                 (dateWanted.Month == 1 && dateWanted.Day <= 20)) &&
                 ((dateWanted2.Month == 12 && dateWanted2.Day >= 20) ||
                 (dateWanted2.Month == 1 && dateWanted2.Day <= 20)))
            {
                return false; // Booking not allowed during this period
            }
            if (dateWanted >= currentDate.AddMonths(2))
            {
                return true;
            }
            else
            {
                return false;
            }     
        }

        public static bool bookedInSixMonthsAdvance(DateTime dateWanted)
        {
            DateTime currentDate = DateTime.Now;

            // Check if the date is within the prohibited period (20th December to 20th January)
            if ((dateWanted.Month == 12 && dateWanted.Day >= 20) || (dateWanted.Month == 1 && dateWanted.Day <= 20))
            {
                return false; // Booking not allowed during this period
            }
            if (dateWanted >= currentDate.AddMonths(6))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string calculateDeposit(int PodID, int CourseID, int noOccs, int noOfDays)
        {
            //initialize deposit cost
            int depositCost = -1;

            //Gets courseCostPerPerson and base costPerNight
            int podCost = PodDal.getPodCost(PodID);
            int courseCost = CourseDal.getCourseCost(CourseID);

            //times cost per person by numOfOccs times cost per night by nights staying
            podCost = podCost * noOfDays;
            courseCost = courseCost * noOccs;

            //add values
            depositCost = podCost + courseCost;

            //return value as a string
            return depositCost.ToString();
        }

        public static string calculateTotal(int PodID, int CourseID, int noOccs, int noOfDays)
        {
            //initialize deposit cost
            int depositCost = -1;

            //Gets courseCostPerPerson and base costPerNight
            int podCost = PodDal.getPodCost(PodID);
            int courseCost = CourseDal.getCourseCost(CourseID);

            //times cost per person by numOfOccs times cost per night by nights staying
            podCost = podCost * noOfDays;
            courseCost = courseCost * noOccs;

            //add values
            depositCost = podCost + courseCost;

            //Total is 2x deposit
            depositCost =  depositCost * 2;

            //return value as a string
            return depositCost.ToString();
        }

        public static string calculateDiscount(string guestID, DateTime dateBooked)
        {
            if (bookedInSixMonthsAdvance(dateBooked) && BookingDal.GuestBookedBefore(guestID))
            {
                return "5";
            }
            else if (bookedInSixMonthsAdvance(dateBooked))
            {
                return "2";
            }
            else if (BookingDal.GuestBookedBefore(guestID))
            {
                return "3";
            }
            else
            {
                return "0";
            }
        }

        public static bool canBookingBeMadePermanent(DateTime dateBooked) 
        {
            DateTime now = DateTime.Now;
            TimeSpan difference = now - dateBooked;
            TimeSpan threeDays = TimeSpan.FromDays(3);

            // If the difference is greater than or equal to three days, booking can not be made permanent
            if (difference >= threeDays)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool validateEmail(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                int countSymbol = 0;
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        countSymbol++;
                    }
                }

                if (countSymbol == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool validatePhoneNumber(string phoneNumber)
        {
            // Check if phone number is not null or empty
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Check if phone number has at least 11 characters
                if (phoneNumber.Length >= 11)
                {
                    // Check each character of the phone number
                    foreach (char c in phoneNumber)
                    {
                        // If any character is not a digit, return false
                        if (!char.IsDigit(c))
                        {
                            return false;
                        }
                    }
                    // All characters are digits
                    return true;
                }
            }
            // Null, empty, or less than 11 characters
            return false;
        }

        public static int guestLengthOfStay(DateTime start, DateTime end)
        {
            TimeSpan difference = end.Subtract(start);
            return difference.Days;
        }

        public static string errorBuilderBookingForm(string guestID, string podID, string courseID, string noOfOccupants)
        {
            string errorMessage = "THE FOLLOWING ERROS HAVE OCCURRED:";
            if (string.IsNullOrEmpty(guestID))
            {
                errorMessage += "----A GuestID has not been selected----";
            }
            if (string.IsNullOrEmpty(podID))
            {
                errorMessage += "----A PodID has not been selected----";
            }
            if (string.IsNullOrEmpty(courseID))
            {
                errorMessage += "----A CourseID has not been selected----";
            }
            if (string.IsNullOrEmpty(noOfOccupants))
            {
                errorMessage += "----A Number of occupants has not been selected----";
            }
            return errorMessage;
        }

        public static string GenerateGuestID(string firstName, string lastName)
        {
            // Take the first letter of the first name and last name
            string initials = firstName.Substring(0, 1) + lastName.Substring(0, 1);

            // Generate a random 3-digit number
            Random rnd = new Random();
            int randomNumber = rnd.Next(100, 1000); // generates a random number between 100 and 999

            // Concatenate the initials and the random number to create the guest ID
            string guestID = initials + randomNumber.ToString();

            return guestID;
        }
    }
}
