using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dzienniczekv2
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string imie,string nazwisko, DateTime data, string plec, string telefon, string adres, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO student (StdImie, StdNazwisko, StdUrodz, StdPlec, StdTelefon, StdAdres,Zdjec) VALUES (@im, @naz, @dat, @ple, @tel, @adr, @imgg);", connect.GetConnection);
            
            command.Parameters.Add("@im", MySqlDbType.VarChar).Value = imie;
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwisko;
            command.Parameters.Add("@dat", MySqlDbType.Date).Value = data;
            command.Parameters.Add("@ple", MySqlDbType.VarChar).Value = plec;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adres;
            command.Parameters.Add("@imgg", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if(command.ExecuteNonQuery()==1)
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
       public DataTable getStudentList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // funkcja liczaca ile osob jest w bazie oraz podzial na kobiety i mezczyzny
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        public string liczbaStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        //liczba kobiet
        public string liczbaKobietStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE StdPlec='Kobieta'");
        }
        public string liczbaMezczyznStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE StdPlec='Mężczyzna'");
        }
        public DataTable szukajStudenta(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM student WHERE CONCAT(StdImie, StdNazwisko, StdAdres) LIKE '%"+searchdata+"%'", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Updejtowanie studenta
        public bool PoprawianieStudenta(int id, string imie, string nazwisko, DateTime data, string plec, string telefon, string adres, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE student SET StudentId=@id, StdImie=@im, StdNazwisko=@naz, StdUrodz=@dat, StdPlec=@ple, StdTelefon=@tel, StdAdres=@adr,Zdjec=@imgg WHERE StudentID=@id", connect.GetConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@im", MySqlDbType.VarChar).Value = imie;
            command.Parameters.Add("@naz", MySqlDbType.VarChar).Value = nazwisko;
            command.Parameters.Add("@dat", MySqlDbType.Date).Value = data;
            command.Parameters.Add("@ple", MySqlDbType.VarChar).Value = plec;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adres;
            command.Parameters.Add("@imgg", MySqlDbType.Blob).Value = img;

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
        //
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool usunStudenta(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE StudentId = @id" , connect.GetConnection);

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
