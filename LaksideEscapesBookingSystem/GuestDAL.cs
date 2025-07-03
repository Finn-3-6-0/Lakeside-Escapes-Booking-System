using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using LaksideEscapesBookingSystem.Models;

namespace LaksideEscapesBookingSystem
{
    class GuestDAL
    {
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;

        public static int AddGuest(string[] guestDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertGuestCommand = new SqlCommand();
                insertGuestCommand.Connection = connection;

                insertGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertGuestCommand.CommandText = "AddGuest";

                insertGuestCommand.Parameters.Add(new SqlParameter("@GuestId", guestDetails[0]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@FirstName", guestDetails[1]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@LastName", guestDetails[2]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@Email", guestDetails[3]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@PhoneNumber", guestDetails[4]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@Title", guestDetails[5]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@AddressLine1", guestDetails[6]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@AddressLine2", guestDetails[7]));
                insertGuestCommand.Parameters.Add(new SqlParameter("@PreviouslyBooked", guestDetails[8]));

                int rowsAffected = insertGuestCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static List<string> GetGuestIDs()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT GuestID FROM Guest");

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
        public static int DeleteGuestByID(string guestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand deleteGuestCommand = new SqlCommand();
                deleteGuestCommand.Connection = connection;

                deleteGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;

                deleteGuestCommand.CommandText = "DeleteGuest";

                deleteGuestCommand.Parameters.Add(new SqlParameter("@GuestID", guestID));

                int rowsAffected = deleteGuestCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }

        public static List<string> GetGuestByGuestID(string guestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> guest = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Guest WHERE GuestID = '{0}'", guestID.ToString());

                SqlCommand getGuestByGuestIDCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getGuestByGuestIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all the information of the booking
                    string guestInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        guestInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}\n";
                    }
                    guest.Add(guestInfo);
                }

                connection.Close();

                return guest;
            }
        }

        public static Guests GetGuestObjectByID(string guestID)
        {
            Guests guest = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Guest WHERE GuestID = @GuestID";

                SqlCommand getGuestByIDCommand = new SqlCommand(sqlQuery, connection);
                getGuestByIDCommand.Parameters.AddWithValue("@GuestID", guestID);

                SqlDataReader reader = getGuestByIDCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Populate a Guests object with data from the database
                    guest = new Guests
                    {
                        GuestID = reader["GuestID"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Title = reader["Title"].ToString(),
                        AddressLine1 = reader["AddressLine1"].ToString(),
                        AddressLine2 = reader["AddressLine2"].ToString()
                    };
                }

                connection.Close();
            }

            return guest;
        }

        public static int UpdateGuest(string[] guestDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updateGuestCommand = new SqlCommand();
                updateGuestCommand.Connection = connection;
                updateGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateGuestCommand.CommandText = "UpdateGuest";

                updateGuestCommand.Parameters.Add(new SqlParameter("@GuestID", guestDetails[0]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@FirstName", guestDetails[1]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@LastName", guestDetails[2]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@Email", guestDetails[3]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@PhoneNumber", guestDetails[4]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@Title", guestDetails[5]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@AddressLine1", guestDetails[6]));
                updateGuestCommand.Parameters.Add(new SqlParameter("@AddressLine2", guestDetails[7]));


                int rowsAffected = updateGuestCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static bool IsIdUnique(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE GuestID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                int count = (int)command.ExecuteScalar();
                return count == 0;
            }
        }

        public static string[] GetGuestNameAndEmailByID(string guestID)
        {
            string[] guestInfo = new string[3]; // Array to store first name, last name, and email

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT FirstName, LastName, Email FROM Guest WHERE GuestID = @GuestID";

                SqlCommand getGuestByIDCommand = new SqlCommand(sqlQuery, connection);
                getGuestByIDCommand.Parameters.AddWithValue("@GuestID", guestID);

                SqlDataReader reader = getGuestByIDCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve first name, last name, and email from the database
                    guestInfo[0] = reader["FirstName"].ToString();
                    guestInfo[1] = reader["LastName"].ToString();
                    guestInfo[2] = reader["Email"].ToString();
                }

                connection.Close();
            }

            return guestInfo;
        }
    }
}
