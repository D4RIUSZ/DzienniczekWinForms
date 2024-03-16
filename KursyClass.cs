using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dzienniczekv2
{
    internal class KursyClass
    {
        DBconnect connect = new DBconnect();
        public bool sqldodajkurs(string nazwa, int godz, string opis)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `kursy`(`Nazwa Kursu`, `Liczba Godzin`, `Opis`) VALUES (@naz,@gdz,@op)", connect.GetConnection);
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwa;
            command.Parameters.Add("@gdz", MySqlDbType.Int32).Value = godz;
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
        public DataTable getKurs(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool sqlzaktualizujkurs(int id, string nazwa, int godz, string opis)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `kursy` SET `Nazwa Kursu`=@naz,`Liczba Godzin`=@gdz,`Opis`=@op WHERE KursId=@id", connect.GetConnection);
            command.Parameters.Add("@id",MySqlDbType.Int32).Value=id;
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwa;
            command.Parameters.Add("@gdz", MySqlDbType.Int32).Value = godz;
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
        public bool usunKurs(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM kursy WHERE KursId=@id",connect.GetConnection);
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
