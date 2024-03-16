using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dzienniczekv2
{
    public partial class Kursy : Form
    {
        
        KursyClass kurs = new KursyClass();
        public Kursy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_NazwaKursu.Text == "" || textBox_liczbaGodzin.Text == "")
            {
                MessageBox.Show("Uzupełnij dane, a anastępnie dodaj kurs", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nazwa = textBox_NazwaKursu.Text;
                int godz = Convert.ToInt32(textBox_liczbaGodzin.Text);
                string opis = textBox_opis.Text;

                if (kurs.sqldodajkurs(nazwa, godz, opis))
                {
                    showData();
                    button_wyczysc.PerformClick();
                    MessageBox.Show("Dodawanie nowego kursu", "Dodaj Kurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nie dodano Kursu", "Dodaj Kurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            textBox_NazwaKursu.Clear();
            textBox_liczbaGodzin.Clear();
            textBox_opis.Clear();
        }

        private void Kursy_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            DataGridView_Kurs.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
        }
    }
}
