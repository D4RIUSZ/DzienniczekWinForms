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
    public partial class ZarzadzajKursy : Form
    {
        KursyClass kurs = new KursyClass();
        public ZarzadzajKursy()
        {
            InitializeComponent();
        }

        private void ZarzadzajKursy_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            DataGridView_Kurs.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            textBox_kursId.Clear();
            textBox_NazwaKursu.Clear();
            textBox_liczbaGodzin.Clear();
            textBox_opis.Clear();
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_NazwaKursu.Text == "" || textBox_liczbaGodzin.Text == "" || textBox_kursId.Text.Equals(""))
            {
                MessageBox.Show("Uzupełnij dane, a anastępnie zaktualizuj kurs", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_kursId.Text);
                string nazwa = textBox_NazwaKursu.Text;
                int godz = Convert.ToInt32(textBox_liczbaGodzin.Text);
                string opis = textBox_opis.Text;

                if (kurs.sqlzaktualizujkurs(id,nazwa, godz, opis))
                {
                    showData();
                    button_wyczysc.PerformClick();
                    MessageBox.Show("Zaktualizowano kurs", "Aktualizuj Kurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nie zaktualizowano Kursu", "Aktualizuj Kurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (textBox_kursId.Text.Equals(""))
            {
                MessageBox.Show("Podaj Id Kursu, a anastępnie zaktualizuj kurs", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_kursId.Text);

                    if (kurs.usunKurs(id))
                    {
                        showData();
                        button_wyczysc.PerformClick();
                        MessageBox.Show("Usunięto kurs", "Usuń Kurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
               
                {
                    MessageBox.Show("Nie usunięto Kursu", "Usuń Kurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_Kurs_Click(object sender, EventArgs e)
        {
            textBox_kursId.Text = DataGridView_Kurs.CurrentRow.Cells[0].Value.ToString();
            textBox_NazwaKursu.Text = DataGridView_Kurs.CurrentRow.Cells[1].Value.ToString();
            textBox_liczbaGodzin.Text = DataGridView_Kurs.CurrentRow.Cells[2].Value.ToString();
            textBox_opis.Text = DataGridView_Kurs.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            {
                DataGridView_Kurs.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy` WHERE CONCAT(`Nazwa Kursu`)LIKE '%" + textBox_szukaj.Text + "%'"));
                textBox_szukaj.Clear();
            }
        }
    }
}
