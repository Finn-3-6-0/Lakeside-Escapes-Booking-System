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
    class PodDal
    {

        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;

        public static int AddPod(string[] podDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertPodCommand = new SqlCommand();
                insertPodCommand.Connection = connection;

                insertPodCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertPodCommand.CommandText = "AddPod";


                //insertPodCommand.Parameters.Add(new SqlParameter("@PodId", podDetails[0]));
                insertPodCommand.Parameters.Add(new SqlParameter("@PodType", podDetails[1]));
                insertPodCommand.Parameters.Add(new SqlParameter("@Capacity", podDetails[2]));
                insertPodCommand.Parameters.Add(new SqlParameter("@BaseCostPerNight", podDetails[3]));


                int rowsAffected = insertPodCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }

        }

        public static List<string> GetPodIDs()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT PodID FROM Pod");

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

        public static int DeletePodByID(int podID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand deletePodCommand = new SqlCommand();
                deletePodCommand.Connection = connection;

                deletePodCommand.CommandType = System.Data.CommandType.StoredProcedure;

                deletePodCommand.CommandText = "DeletePod";

                deletePodCommand.Parameters.Add(new SqlParameter("@PodID", podID));

                int rowsAffected = deletePodCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }


        }
        public static int getPodCost(int podID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand getCostCommand = new SqlCommand();
                getCostCommand.Connection = connection;

                getCostCommand.CommandType = System.Data.CommandType.StoredProcedure;

                getCostCommand.CommandText = "PodCost";

                getCostCommand.Parameters.Add(new SqlParameter("@PodID", podID));

                var podCost = getCostCommand.ExecuteScalar();

                connection.Close();
                return (int)podCost;
            }
        }

        public static List<string> GetPodsByPodID(int podID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> pods = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Pod WHERE PodID = '{0}'", podID.ToString());

                SqlCommand getPodsByPodIDCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getPodsByPodIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all the information of the booking
                    string podInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        podInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}\n";
                    }
                    pods.Add(podInfo);
                }

                connection.Close();

                return pods;
            }
        }

        public static Pods GetPodObjectByID(int podID)
        {
            Pods pod = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Pod WHERE PodID = @PodID";

                SqlCommand getPodByIDCommand = new SqlCommand(sqlQuery, connection);
                getPodByIDCommand.Parameters.AddWithValue("@PodID", podID);

                SqlDataReader reader = getPodByIDCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Populate a Courses object with data from the database
                    pod = new Pods
                    {
                        PodID  = (int)reader["PodID"],
                        PodType = reader["PodType"].ToString(),
                        Capacity = reader["Capacity"].ToString(),
                        BaseCostPerNight = (int)reader["BaseCostPerNight"]
                    };
                }

                connection.Close();
            }

            return pod;
        }

        public static int UpdatePod(string[] podDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updatePodCommand = new SqlCommand();
                updatePodCommand.Connection = connection;
                updatePodCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updatePodCommand.CommandText = "UpdatePod";

                updatePodCommand.Parameters.Add(new SqlParameter("@PodID", podDetails[0]));
                updatePodCommand.Parameters.Add(new SqlParameter("@PodType", podDetails[1]));
                updatePodCommand.Parameters.Add(new SqlParameter("@Capacity", podDetails[2]));
                updatePodCommand.Parameters.Add(new SqlParameter("@BaseCostPerNight", podDetails[3]));


                int rowsAffected = updatePodCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static int getPodCapacity(int podID)
        {
            int capacity = 0;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT Capacity FROM Pod WHERE PodID = @PodID";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@PodID", podID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    capacity = Convert.ToInt32(reader["Capacity"]);
                }

                connection.Close();
            }

            return capacity;
        }

        public static string GetPodTypeByPodID(int podID)
        {
            string podType = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetPodTypeByPodID";

                // Add parameters
                command.Parameters.AddWithValue("@PodID", podID);

                // Execute the command to retrieve the pod type
                object result = command.ExecuteScalar();

                // Check if the result is not null and convert it to string
                if (result != null)
                {
                    podType = result.ToString();
                }

                connection.Close();
            }

            return podType;
        }

       


    }
}

