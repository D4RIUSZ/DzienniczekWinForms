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
    public partial class ZarzadzajOceny : Form
    {
        KursyClass kurs = new KursyClass();
        OcenyClass ocena1 = new OcenyClass();

        public ZarzadzajOceny()
        {
            InitializeComponent();
        }

        private void ZarzadzajOceny_Load(object sender, EventArgs e)
        {
            comboBox_Wybierzkurs.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
            comboBox_Wybierzkurs.DisplayMember = "`Nazwa Kursu`";
            comboBox_Wybierzkurs.ValueMember = "Nazwa Kursu";
            pokazOceny();
        }
        public void pokazOceny()
        {
            DataGridView_ZarzadzajOceny.DataSource = ocena1.getList(new MySqlCommand("SELECT oceny.StudentId, student.StdImie, student.StdNazwisko, oceny.NazwaKursu, oceny.Ocena, oceny.Opis FROM student INNER JOIN oceny ON oceny.StudentId=student.StudentId"));
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_StudentId.Text == "" || textBox_Ocena.Text == "")
            {
                MessageBox.Show("Uzupełnij dane, a anastępnie edytuj ocenę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdid = Convert.ToInt32(textBox_StudentId.Text);
                string nazwa = comboBox_Wybierzkurs.Text;
                int ocena = Convert.ToInt32(textBox_Ocena.Text);
                string opis = textBox_opis.Text;


                if (ocena1.sqledytujocene(stdid, ocena, nazwa, opis))
                {
                        MessageBox.Show("Edytowano ocenę", "Edytowanie oceny", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pokazOceny();
                }
                else
                {
                        MessageBox.Show("Nie edytowano oceny", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                

            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (textBox_StudentId.Text.Equals(""))
            {
                MessageBox.Show("Musisz wprowadzić ID oceny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_StudentId.Text);
                    if (ocena1.usunOcene(id))
                    {
                        pokazOceny();
                        button_wyczysc.PerformClick();
                        MessageBox.Show("Usunięto ocenę", "Usuwanie oceny", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Usuwanie oceny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            textBox_StudentId.Clear();
            textBox_Ocena.Clear();
            textBox_opis.Clear();
            textBox_szukaj.Clear();
        }

        private void DataGridView_ZarzadzajOceny_Click(object sender, EventArgs e)
        {
            textBox_StudentId.Text = DataGridView_ZarzadzajOceny.CurrentRow.Cells[0].Value.ToString();
            comboBox_Wybierzkurs.Text = DataGridView_ZarzadzajOceny.CurrentRow.Cells[3].Value.ToString();
            textBox_Ocena.Text = DataGridView_ZarzadzajOceny.CurrentRow.Cells[4].Value.ToString();
            textBox_opis.Text = DataGridView_ZarzadzajOceny.CurrentRow.Cells[5].Value.ToString();
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            DataGridView_ZarzadzajOceny.DataSource = ocena1.getList(new MySqlCommand("SELECT oceny.StudentId, student.StdImie, student.StdNazwisko, oceny.NazwaKursu, oceny.Ocena, oceny.Opis FROM student INNER JOIN oceny ON oceny.StudentId=student.StudentId WHERE CONCAT(student.StdImie,student.StdNazwisko,oceny.NazwaKursu)LIKE '%"+textBox_szukaj.Text+"%'"));
        }

        private void DataGridView_ZarzadzajOceny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
