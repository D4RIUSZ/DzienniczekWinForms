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
    public partial class Zarzadzanie : Form
    {
        StudentClass student = new StudentClass();
        public Zarzadzanie()
        {
            InitializeComponent();
        }

        private void Zarzadzanie_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            DataGridViewStudent.DataSource = student.getStudentList(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridViewStudent_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
            textBox_imie.Text = DataGridViewStudent.CurrentRow.Cells[1].Value.ToString();
            textBox_nazwisko.Text = DataGridViewStudent.CurrentRow.Cells[2].Value.ToString();
            DateTime_urodz.Value = (DateTime)DataGridViewStudent.CurrentRow.Cells[3].Value;
            if (DataGridViewStudent.CurrentRow.Cells[4].Value.ToString() == "Mężczyzna")
                radioButton_men.Checked = true;
            else
                radioButton_women.Checked = true;
            textBox_telefon.Text = DataGridViewStudent.CurrentRow.Cells[5].Value.ToString();
            textBox_adres.Text = DataGridViewStudent.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridViewStudent.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_Student.Image = Image.FromStream(ms);

        }

        private void button_clear_Click(object sender, EventArgs e)

        {
            textBox_imie.Clear();
            textBox_nazwisko.Clear();
            textBox_telefon.Clear();
            textBox_adres.Clear();
            //pictureBox_Student = null;
            textBox_id.Clear();
            DateTime_urodz.Value = DateTime.Now;
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

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            DataGridViewStudent.DataSource = student.szukajStudenta(textBox_szukaj.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_popraw_Click(object sender, EventArgs e)
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
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Wiek Studenta musi być większy od 10 a mniejszy od 100", "Nieprawidłowy Wiek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    //dodawanie zdjecia
                    MemoryStream ms = new MemoryStream();
                    pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.PoprawianieStudenta(id,imie, nazwisko, data, plec, telefon, adres, img))
                    {
                        MessageBox.Show("Student Poprawiony", "Poprawianie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie poprawiono Studenta !!!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zostawiłeś Puste Pole", "Poprawianie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button_usun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            if (MessageBox.Show("Czy chcesz usunąć studenta", "Usuwanie Studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.usunStudenta(id))
                {
                    showTable();
                    MessageBox.Show("Student Usunięty", "Usuwanie Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }
    }
}
