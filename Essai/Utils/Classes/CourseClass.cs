using Essai.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Utils.Classes
{
    internal class CourseClass
    {
        DbConnect connect = new DbConnect();
        // create function to insert  course
        public bool insertCourse(string cName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`( `courseName`, `courseHour`, `courseDescription`) VALUES (@cn,@ch,@desc)", connect.GetConnection);
            //@cn,@ch,@desc
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        // function to get course list 
        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        // create an update function for course editing
        public bool updateCourse(int id, string cName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `courseName`=@cn,`courseHour`=@ch,`courseDescription`=@desc WHERE courseId=@id\r\n", connect.GetConnection);
            //@id,@cn,@ch,@desc
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        // create a function to delete a course
        // we only need course id
        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE courseId=@id", connect.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }


    }
}
