using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Essai.Utils;
using MySql.Data.MySqlClient;


namespace Essai.Utils.Classes
{
    internal class EmployeeClass
    {
        DbConnect connect = new DbConnect();
        // create function to add a new employees to database
        public bool insertEmployee(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee`( `EmployeeFirstName`, `EmployeeLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES (@fn,@ln,@bd,@gd,@ph,@ad,@img)", connect.GetConnection);
            //@fn,@ln,@bd,@gd,@ph,@ad,@img
            command.Parameters.Add("fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("ad", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("img", MySqlDbType.Blob).Value = img;


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

        // to get employees table 
        public DataTable getEmployeeList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //create a function to execute the count query(total , male ,female)
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;

        }
        // to get employees number
        public string totalEmployees()
        {
            return exeCount("SELECT COUNT(*) FROM `employee`");
        }
        // to get the male employee count
        public string maleEmployees()
        {
            return exeCount("SELECT COUNT(*) FROM `employee` WHERE Gender='Male'");
        }
        // to get the male employee count
        public string femaleEmployees()
        {
            return exeCount("SELECT COUNT(*) FROM `employee` WHERE Gender='Female'");
        }

        // create a function to search for employee (firstname , lastname , address)
        public DataTable searchEmployee(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE CONCAT( `EmployeeFirstName`,`EmployeeLastName`,`Address`) LIKE '%" + searchData + "%'", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        // create a function to edit employee
        public bool updateEmployee(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `employee` SET `EmployeeFirstName`=@fn,`EmployeeLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@ad,`Photo`=@img WHERE `EmployeeId`=@id", connect.GetConnection);
            //@fn,@ln,@bd,@gd,@ph,@ad,@img
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;


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

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `employee` WHERE `EmployeeId`=@id", connect.GetConnection);

            //@id
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


        // create a function for any command in EmployeeDb
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

}
