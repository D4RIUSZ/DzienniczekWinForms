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
    public partial class Logowanie : Form
    {
        StudentClass student = new StudentClass();
        public Logowanie()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "" || textBox_haslo.Text == "")
            {
                MessageBox.Show("Musisz wprowadzić login i hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string login = textBox_login.Text;
                string pass = textBox_haslo.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `logowanie` WHERE `login`='" + login + "' AND `haslo`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    StronaGlowna main = new StronaGlowna();
                    this.Hide();
                    main.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Login lub hasło nie jest poprawne", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
