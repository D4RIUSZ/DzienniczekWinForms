using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczekv2
{
    internal class OcenyClass
    {
        DBconnect connect = new DBconnect();
        public bool sqldodajocene(int stdid, string nazwa1, double ocena, string opis)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `oceny`(`StudentId`, `NazwaKursu`, `Ocena`, `Opis`) VALUES (@stid,@naz,@oce,@op)", connect.GetConnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwa1;
            command.Parameters.Add("@oce", MySqlDbType.Double).Value = ocena;
            command.Parameters.Add("@op", MySqlDbType.VarChar).Value = opis;
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
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool checkOCena(int stdid, string nazwa)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `oceny` WHERE `StudentId`='"+stdid+"'AND `NazwaKursu`='"+nazwa+"'"));
            if(table.Rows.Count >0)
            { return true; }
            else
            { return false; }
        }
        public bool sqledytujocene(int stdid, double ocena, string nazwa, string opis)
        {
            MySqlCommand command = new MySqlCommand("UPDATE oceny SET Ocena=@oce,Opis=@op WHERE StudentId=@stid AND NazwaKursu=@naz", connect.GetConnection);
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwa;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@oce", MySqlDbType.Double).Value = ocena;
            command.Parameters.Add("@op", MySqlDbType.VarChar).Value = opis;
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

        public bool usunOcene(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `oceny` WHERE `StudentId`=@id", connect.GetConnection);
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
