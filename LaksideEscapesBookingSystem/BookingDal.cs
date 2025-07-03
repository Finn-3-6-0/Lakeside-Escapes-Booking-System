using LaksideEscapesBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LaksideEscapesBookingSystem
{
    class BookingDal
    {
        //"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\finne\SSDNot1Drive\Year14\SSD\LaksideEscapesBookingSystem\LaksideEscapesBookingSystem\BookingDatbase.mdf;Integrated Security=True"
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\finne\\SSDNot1Drive\\Year14\\SSD\\LaksideEscapesBookingSystem\\LaksideEscapesBookingSystem\\BookingDatbase.mdf;Integrated Security=True";



        //C:\Users\finne\SSDNot1Drive\Year14\SSD\LaksideEscapesBookingSystem\LaksideEscapesBookingSystem\BookingDatabase.mdf
        //"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BookingDatabase.mdf; Integrated Security=True;"

        public static int AddBooking(string[] bookingInfo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                //string sqlQuery = string.Format("INSERT INTO Booking VALUES(@BookingID, @GuestID, @PodID, @CourseID, @NumberOfOccupants, @CheckInDate, @CheckOutDate, @BookingStatus, @DepositAmount, @DiscountPercentage, @TotalAmount)");

                SqlCommand insertBookingCommand = new SqlCommand();
                insertBookingCommand.Connection = connection;

                insertBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertBookingCommand.CommandText = "AddBooking";


                //insertProjectCommand.Parameters.AddWithValue("@CheckInDate", SqlDbType.DateTime).Value = DateTime.Now;
                //insertProjectCommand.Parameters.AddWithValue("@CheckOutDate", SqlDbType.DateTime).Value = DateTime.Now.AddDays(1);


                // Retrieve the datetime string from the array
                string datetimeString = bookingInfo[5];
                string datetimeString2 = bookingInfo[6];
                string dateBookedString = bookingInfo[11];


                // Convert the string to a DateTime object
                DateTime bookingDateTime;
                DateTime bookingDateTime2;
                DateTime dateBooked;



                if (DateTime.TryParse(datetimeString, out bookingDateTime) && DateTime.TryParse(datetimeString2, out bookingDateTime2) && DateTime.TryParse(dateBookedString, out dateBooked))
                {
                    //insertBookingCommand.Parameters.Add(new SqlParameter("@BookingID", bookingInfo[0]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@GuestID", bookingInfo[1]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@PodID", bookingInfo[2]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@CourseID", bookingInfo[3]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@NumberOfOccupants", bookingInfo[4]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@CheckInDate", bookingDateTime));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@CheckOutDate", bookingDateTime2));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@BookingStatus", bookingInfo[7]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@DepositAmount", bookingInfo[8]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@DiscountPercentage", bookingInfo[9]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@TotalAmount", bookingInfo[10]));
                    insertBookingCommand.Parameters.Add(new SqlParameter("@DateBooked", dateBooked));
                }
                else
                {
                    Console.WriteLine("Invalid DateTime format");
                }


                int rowsAffected = insertBookingCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static List<string> GetBookingsByBookingID(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Booking WHERE BookingID = '{0}'", bookingID.ToString());

                SqlCommand getBookingsByBookingIDCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getBookingsByBookingIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all the information of the booking
                    string bookingInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        bookingInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}\n";
                    }
                    bookings.Add(bookingInfo);
                }

                connection.Close();

                return bookings;
            }
        }

        public static List<string> GetBookingsIDs()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT BookingID FROM Booking");

                SqlCommand getBookingsByBookingIDCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getBookingsByBookingIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all information about the booking
                    string bookingInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        bookingInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}";
                    }
                    bookings.Add(bookingInfo);
                }

                connection.Close();

                return bookings;
            }
        }
        public static int DeleteBookingByID(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand deleteBookingCommand = new SqlCommand();
                deleteBookingCommand.Connection = connection;

                deleteBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;

                deleteBookingCommand.CommandText = "DeleteBooking";

                deleteBookingCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));

                int rowsAffected = deleteBookingCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }

        public static int getNoOfOccs(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand readNoOfOccCommand = new SqlCommand();
                readNoOfOccCommand.Connection = connection;

                readNoOfOccCommand.CommandType = System.Data.CommandType.StoredProcedure;

                readNoOfOccCommand.CommandText = "BookingOccupants";

                readNoOfOccCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));

                var items = readNoOfOccCommand.ExecuteScalar();

                connection.Close();
                return (int)items;
            }
        }

        public static List<string> getStartAndEndDate(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                SqlCommand getDateCommand = new SqlCommand();
                getDateCommand.Connection = connection;

                getDateCommand.CommandType = System.Data.CommandType.StoredProcedure;

                getDateCommand.CommandText = "BookingLengthOfStay";

                getDateCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                SqlDataReader sqlDataReader = getDateCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all information about the booking
                    string bookingInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        bookingInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}";
                    }
                    bookings.Add(bookingInfo);
                }


                connection.Close();
                return bookings;
            }
        }

        public static bool GuestBookedBefore(string guestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand bookedBeforeCommand = new SqlCommand();
                bookedBeforeCommand.Connection = connection;

                bookedBeforeCommand.CommandType = System.Data.CommandType.StoredProcedure;

                bookedBeforeCommand.CommandText = "CheckGuestBooking";

                bookedBeforeCommand.Parameters.Add(new SqlParameter("@GuestID", guestID));

                int rowsAffected = bookedBeforeCommand.ExecuteNonQuery();

                connection.Close();
                return true;
            }

        }

        public static Bookings GetBookingObjectByID(int bookingID)
        {
            Bookings booking = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Booking WHERE BookingID = @BookingID";

                SqlCommand getBookingByIDCommand = new SqlCommand(sqlQuery, connection);
                getBookingByIDCommand.Parameters.AddWithValue("@BookingID", bookingID);

                SqlDataReader reader = getBookingByIDCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Populate a Bookings object with data from the database
                    booking = new Bookings
                    {
                        BookingID = (int)reader["BookingID"],
                        GuestID = reader["GuestID"].ToString(),
                        PodID = (int)reader["PodID"],
                        CourseID = (int)reader["CourseID"],
                        NumberOfOccupants = (int)reader["NumberOfOccupants"],
                        CheckInDate = (DateTime)reader["CheckInDate"],
                        CheckOutDate = (DateTime)reader["CheckOutDate"],
                        BookingStatus = reader["BookingStatus"].ToString(),
                        DepositAmount = (int)reader["DepositAmount"],
                        DiscountPercentage = (int)reader["DiscountPercentage"],
                        TotalAmount = (int)reader["TotalAmount"]
                    };
                }

                connection.Close();
            }

            return booking;
        }

        public static int UpdateBooking(string[] bookingInfo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updateBookingCommand = new SqlCommand();
                updateBookingCommand.Connection = connection;
                updateBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateBookingCommand.CommandText = "UpdateBooking";

                // Retrieve the datetime string from the array
                string datetimeString = bookingInfo[5];
                string datetimeString2 = bookingInfo[6];
                string dateBookedString = bookingInfo[11];

                // Convert the string to a DateTime object
                DateTime bookingDateTime;
                DateTime bookingDateTime2;
                DateTime dateBooked;

                if (DateTime.TryParse(datetimeString, out bookingDateTime) && DateTime.TryParse(datetimeString2, out bookingDateTime2) && DateTime.TryParse(dateBookedString, out dateBooked))
                {
                    updateBookingCommand.Parameters.Add(new SqlParameter("@BookingID", bookingInfo[0]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@GuestID", bookingInfo[1]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@PodID", bookingInfo[2]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@CourseID", bookingInfo[3]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@NumberOfOccupants", bookingInfo[4]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@CheckInDate", bookingDateTime));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@CheckOutDate", bookingDateTime2));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@BookingStatus", bookingInfo[7]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@DepositAmount", bookingInfo[8]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@DiscountPercentage", bookingInfo[9]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@TotalAmount", bookingInfo[10]));
                    updateBookingCommand.Parameters.Add(new SqlParameter("@DateBooked", dateBooked));
                }
                else
                {
                    Console.WriteLine("Invalid DateTime format");
                    return 0; // Or handle the error as appropriate for your application
                }

                int rowsAffected = updateBookingCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static bool DoesBookingOverlap(string podId, DateTime checkInDate, DateTime checkOutDate, int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Booking WHERE PodId = @PodId AND CheckOutDate > @CheckInDate AND CheckInDate < @CheckOutDate";
                if (bookingID > 0)
                {
                    // If a bookingID is passed, exclude it from the overlapping bookings check
                    query += " AND BookingID <> @BookingID";
                }
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PodId", podId);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                if (bookingID > 0)
                {
                    // If a bookingID is passed, set its value as a parameter
                    command.Parameters.AddWithValue("@BookingID", bookingID);
                }
                int overlappingBookingsCount = (int)command.ExecuteScalar();

                // If overlapping bookings count is 0, then there are no overlapping bookings
                return overlappingBookingsCount == 0;
            }
        }


        public static bool DoesNoOccsExceedCapacity(int podID, int numberOfOccupants)
        {
            int podCapacity = PodDal.getPodCapacity(podID);
            if (podCapacity >= numberOfOccupants)
            {
                return false; // Occupants do not exceed pod capacity
            }
            else
            {
                return true; // Occupants exceed pod capacity
            }
        }

        public static int UpdateBookingStatusToPermanent(int bookingID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updateStatusCommand = new SqlCommand();
                updateStatusCommand.Connection = connection;
                updateStatusCommand.CommandType = CommandType.StoredProcedure;
                updateStatusCommand.CommandText = "UpdateBookingStatusToPermanent";

                updateStatusCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));

                rowsAffected = updateStatusCommand.ExecuteNonQuery();

                connection.Close();
            }

            return rowsAffected;
        }

        public static DateTime getDateBooked(int bookingId)
        {
            DateTime dateBooked = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand getDateBookedCommand = new SqlCommand();
                getDateBookedCommand.Connection = connection;
                getDateBookedCommand.CommandType = CommandType.StoredProcedure;
                getDateBookedCommand.CommandText = "GetDateBooked";

                getDateBookedCommand.Parameters.AddWithValue("@BookingID", bookingId);

                // Execute the command to retrieve the date booked
                object result = getDateBookedCommand.ExecuteScalar();

                // Check if the result is not null and convert it to string
                if (result != null)
                {
                    dateBooked = (DateTime)result;
                }

                connection.Close();
            }

            return dateBooked;
        }

       
        public static int DeleteExpiredBookings()
        {
                int rowsAffected = 0;

             using (SqlConnection connection = new SqlConnection(_connectionstring))
             {
                 connection.Open();

                 // Calculate the cutoff date (3 days older than current date time)
                 DateTime cutoffDate = DateTime.Now.AddDays(-3);

                 // Prepare the SQL command to delete bookings
                 SqlCommand deleteCommand = new SqlCommand();
                 deleteCommand.Connection = connection;
                 deleteCommand.CommandType = CommandType.StoredProcedure;
                 deleteCommand.CommandText = "DeleteExpiredBookings";
                 deleteCommand.Parameters.AddWithValue("@CutoffDate", cutoffDate);

                 // Execute the command and get the number of rows affected
                 rowsAffected = deleteCommand.ExecuteNonQuery();

                 connection.Close();
             }

             return rowsAffected;
        }

        public static string GetGuestIDByBookingID(int bookingID)
        {
            string guestID = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetGuestIDByBookingID";

                // Add parameters
                command.Parameters.AddWithValue("@BookingID", bookingID);

                // Execute the command to retrieve the guest ID
                object result = command.ExecuteScalar();

                // Check if the result is not null and convert it to string
                if (result != null)
                {
                    guestID = result.ToString();
                }

                connection.Close();
            }

            return guestID;
        }

        public static int GetPodIDByBookingID(int bookingID)
        {
            int podID = -1; // Initialize to an invalid value

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetPodIDByBookingID";

                // Add parameters
                command.Parameters.AddWithValue("@BookingID", bookingID);

                // Execute the command to retrieve the pod ID
                object result = command.ExecuteScalar();

                // Check if the result is not null and convert it to an integer
                if (result != null && result != DBNull.Value)
                {
                    podID = Convert.ToInt32(result);
                }

                connection.Close();
            }

            return podID;
        }

        public static int GetCourseIDByBookingID(int bookingID)
        {
            int courseID = -1; // Initialize to an invalid value

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCourseIDByBookingID";

                // Add parameters
                command.Parameters.AddWithValue("@BookingID", bookingID);

                // Execute the command to retrieve the course ID
                object result = command.ExecuteScalar();

                // Check if the result is not null and convert it to an integer
                if (result != null && result != DBNull.Value)
                {
                    courseID = Convert.ToInt32(result);
                }

                connection.Close();
            }

            return courseID;
        }

        public static string[] GetBookingDetailsByBookingID(int bookingID)
        {
            string[] bookingDetails = new string[5]; 

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetBookingDetailsByBookingID";

                // Add parameters
                command.Parameters.AddWithValue("@BookingID", bookingID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the values from the reader and store them in the array
                    bookingDetails[0] = reader["CheckInDate"].ToString();
                    bookingDetails[1] = reader["CheckOutDate"].ToString();
                    bookingDetails[2] = reader["NumberOfOccupants"].ToString();
                    bookingDetails[3] = reader["DateBooked"].ToString();
                    // Read and store the total amount
                    bookingDetails[4] = reader["TotalAmount"].ToString();
                }

                connection.Close();
            }

            return bookingDetails;
        }

    }
}
