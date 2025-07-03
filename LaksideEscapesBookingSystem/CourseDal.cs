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
    class CourseDal
    {

        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;

        public static int AddCourse(string[] courseDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertCourseCommand = new SqlCommand();
                insertCourseCommand.Connection = connection;

                insertCourseCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertCourseCommand.CommandText = "AddCourse";

                //insertCourseCommand.Parameters.Add(new SqlParameter("@CourseID", courseDetails[0]));
                insertCourseCommand.Parameters.Add(new SqlParameter("@CourseName", courseDetails[1]));
                insertCourseCommand.Parameters.Add(new SqlParameter("@CoursecostPerPerson", courseDetails[2]));


                int rowsAffected = insertCourseCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }
        public static List<string> GetCourseIDs()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> bookings = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT CourseID FROM Course");

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

        public static int DeleteCourseByID(int courseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand deleteCourseCommand = new SqlCommand();
                deleteCourseCommand.Connection = connection;

                deleteCourseCommand.CommandType = System.Data.CommandType.StoredProcedure;

                deleteCourseCommand.CommandText = "DeleteCourse";

                deleteCourseCommand.Parameters.Add(new SqlParameter("@CourseID", courseID));

                int rowsAffected = deleteCourseCommand.ExecuteNonQuery();

                connection.Close();
                return rowsAffected;
            }

        }

        public static int getCourseCost(int courseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand getCourseCostCommand = new SqlCommand();
                getCourseCostCommand.Connection = connection;

                getCourseCostCommand.CommandType = System.Data.CommandType.StoredProcedure;

                getCourseCostCommand.CommandText = "CourseCost";

                getCourseCostCommand.Parameters.Add(new SqlParameter("@CourseID", courseID));

                var rowsAffected = getCourseCostCommand.ExecuteScalar();

                connection.Close();
                return (int)rowsAffected;
            }
        }

        public static List<string> GetCoursesByCourseID(int courseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<string> courses = new List<string>();

                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Course WHERE CourseID = '{0}'", courseID.ToString());

                SqlCommand getCoursesByCourseIDCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getCoursesByCourseIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    // Construct a string containing all the information of the booking
                    string courseInfo = "";
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        courseInfo += $"{sqlDataReader.GetName(i)}: {sqlDataReader[i]}\n";
                    }
                    courses.Add(courseInfo);
                }

                connection.Close();

                return courses;
            }
        }

        public static Courses GetCourseObjectByID(int courseID)
        {
            Courses course = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Course WHERE CourseID = @CourseID";

                SqlCommand getCourseByIDCommand = new SqlCommand(sqlQuery, connection);
                getCourseByIDCommand.Parameters.AddWithValue("@CourseID", courseID);

                SqlDataReader reader = getCourseByIDCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Populate a Courses object with data from the database
                    course = new Courses
                    {                      
                        CourseID = (int)reader["CourseID"],
                        CourseName = reader["CourseName"].ToString(),
                        CourseCostPerPerson = (int)reader["CourseCostPerPerson"],
                    };
                }

                connection.Close();
            }

            return course;
        }

        public static int UpdateCourse(string[] courseDetails)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updateCourseCommand = new SqlCommand();
                updateCourseCommand.Connection = connection;
                updateCourseCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateCourseCommand.CommandText = "UpdateCourse";

                updateCourseCommand.Parameters.Add(new SqlParameter("@CourseID", courseDetails[0]));
                updateCourseCommand.Parameters.Add(new SqlParameter("@CourseName", courseDetails[1]));
                updateCourseCommand.Parameters.Add(new SqlParameter("@CourseCostPerPerson", courseDetails[2]));

                int rowsAffected = updateCourseCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }
        public static string GetCourseNameByCourseID(int courseID)
        {
            string courseName = null;

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCourseNameByCourseID";

                // Add parameters
                command.Parameters.AddWithValue("@CourseID", courseID);

                // Execute the command to retrieve the course name
                object result = command.ExecuteScalar();

                // Check if the result is not null and convert it to string
                if (result != null)
                {
                    courseName = result.ToString();
                }

                connection.Close();
            }

            return courseName;
        }

    }
}

