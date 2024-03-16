using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Dzienniczekv2
{
    public partial class Rejestracja : Form
    {
        StudentClass student = new StudentClass();
        public Rejestracja()
        {
            InitializeComponent();
        }

      

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Student.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_imie.Clear();
            textBox_nazwisko.Clear();
            textBox_telefon.Clear();
            textBox_adres.Clear();
            pictureBox_Student = null;
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string imie = textBox_imie.Text;
            string nazwisko = textBox_nazwisko.Text;
            DateTime data = DateTime_urodz.Value;
            string telefon = textBox_telefon.Text;
            string adres = textBox_adres.Text;
            string plec = radioButton_men.Checked ? "Mężczyzna" : "Kobieta";
            

            //ograniczenie wiweku studenta
            int born_year = DateTime_urodz.Value.Year;
            int this_year = DateTime.Now.Year;  
            if((this_year-born_year)<10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Wiek Studenta musi być większy od 10 a mniejszy od 100","Nieprawidłowy Wiek",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(verify())
            {
                try
                {
                    //dodawanie zdjecia
                    MemoryStream ms = new MemoryStream();
                    pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.insertStudent(imie, nazwisko,data,plec,telefon,adres, img))
                    {
                        MessageBox.Show("Dodano nowego Studenta", "Dodawanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Nie Dodano Studenta !!!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zostawiłeś Puste Pole", "Dodawanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if ((textBox_imie.Text == "") || (textBox_nazwisko.Text == "") ||
              (textBox_telefon.Text == "") || (textBox_adres.Text == "") ||
              (pictureBox_Student.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
       public void showTable()
        {
            DataGridViewStudent.DataSource = student.getStudentList(new MySqlCommand("SELECT * FROM student"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
     
        private void Form2_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void pictureBox_Student_Click(object sender, EventArgs e)
        {

        }
    }
}
