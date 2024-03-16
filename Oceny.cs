using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzienniczekv2
{
    public partial class Oceny : Form
    {
        KursyClass kurs =new KursyClass();
        StudentClass students = new StudentClass();
        OcenyClass ocena1 =  new OcenyClass();

        public Oceny()
        {
            InitializeComponent();
        }
        private void showOceny()
        {
            DataGridView_ListaStudentow.DataSource = ocena1.getList(new MySqlCommand("SELECT oceny.StudentId, student.StdImie, student.StdNazwisko, oceny.NazwaKursu, oceny.Ocena, oceny.Opis FROM student INNER JOIN oceny ON oceny.StudentId=student.StudentId"));
        }
        private void Oceny_Load(object sender, EventArgs e)
        {
            comboBox_Wybierzkurs.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
            comboBox_Wybierzkurs.DisplayMember = "`Nazwa Kursu`";
            comboBox_Wybierzkurs.ValueMember = "Nazwa Kursu";

            DataGridView_ListaStudentow.DataSource = students.getList(new MySqlCommand("SELECT `StudentId`,`StdImie`,`StdNazwisko` FROM `student`"));
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || textBox_Ocena.Text == "")
            {
                MessageBox.Show("Uzupełnij dane, a anastępnie dodaj ocenę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdid=Convert.ToInt32(textBox_studentId.Text);
                string nazwa = comboBox_Wybierzkurs.Text;
                int ocena = Convert.ToInt32(textBox_Ocena.Text);
                string opis = textBox_opis.Text;
                if (!ocena1.checkOCena(stdid, nazwa))
                {

                    if (ocena1.sqldodajocene(stdid, nazwa, ocena, opis))
                    {
                        showOceny();
                        MessageBox.Show("Dodano nową ocenę", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano oceny", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ta osoba już ma ocenę z tego kursu","Dodaj ocenę",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            textBox_studentId.Clear();
            textBox_Ocena.Clear();
            comboBox_Wybierzkurs.SelectedIndex = 0;
            textBox_opis.Clear();
        }

        private void DataGridView_ListaStudentow_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text =DataGridView_ListaStudentow.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_PokazStudenta_Click(object sender, EventArgs e)
        {
            DataGridView_ListaStudentow.DataSource = students.getList(new MySqlCommand("SELECT `StudentId`,`StdImie`,`StdNazwisko` FROM `student`"));
        }

        private void button_pokazOceny_Click(object sender, EventArgs e)
        {
            showOceny();
        }
    }
}
