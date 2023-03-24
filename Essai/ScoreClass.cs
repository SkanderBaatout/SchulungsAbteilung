using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai
{
    internal class ScoreClass
    {
        DbConnect connect = new DbConnect();
        // create function to add score
        public bool insertScore(int stid,string courName, double scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`EmployeeId`, `CourseName`, `Score`, `Description`) VALUES(@stid, @cn, @sco, @desc)", connect.GetConnection);
            //@stid,@cn,@sco,@desc
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courName;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = scor;
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

        // create a function to get List
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // create a function to check if course already have a score or not
        public bool checkScore(int stid,string cName)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `EmployeeId`=  '"+ stid + "'  AND `CourseName`=  '"+   cName +"' "));
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false; 
        }

        // create function to edit score data 
        public bool updateScore(int stid,string scn , double scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sco,`Description`=@desc  WHERE `EmployeeId`=@stid AND `CourseName`=@scn\r\n", connect.GetConnection);
            //@stid,@sco,@desc

            command.Parameters.Add("@scn", MySqlDbType.VarChar).Value = scn;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = scor;
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

        // function to delete score data 
        public bool deleteScore(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `EmployeeId`=@id", connect.GetConnection);

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


    }
}
