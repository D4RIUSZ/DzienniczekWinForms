using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzienniczekv2
{
    public partial class StronaGlowna : Form
    {
        StudentClass student = new StudentClass();
        KursyClass Kursy = new KursyClass();

        public StronaGlowna()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void StronaGlowna_Load_1(object sender, EventArgs e)
        {
            licznikstudent();
            comboBox1.DataSource = Kursy.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
            comboBox1.DisplayMember = "Nazwa Kursu";
            comboBox1.ValueMember = "Nazwa Kursu";
            timer_kalendarzyk.Start();
            chart();

        }

        private void licznikstudent()
        {
            label_WszystkichStudentow.Text = "Wszystkich studentow: " + student.liczbaStudent();
            label_wszystkichKobiet.Text = "Kobiet: " + student.liczbaKobietStudent();
            label_wszystkichmezczyzn.Text = "Mężczyzn: " + student.liczbaMezczyznStudent();

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_kursmenu.Visible = false;
            panel_ocenamenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_kursmenu.Visible == true)
                panel_kursmenu.Visible = false;
            if (panel_ocenamenu.Visible == true)
                panel_ocenamenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_student_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region student
        private void button_rejestracja_Click(object sender, EventArgs e)
        {
            
        }
        private void button_rejestracja_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new Rejestracja());
        }

        private void button_zarzadzanie_student_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_zarzadzanie_student_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new Zarzadzanie());
        }
        private void button_status_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_student_drukuj_Click(object sender, EventArgs e)
        {
            openChildForm(new Drukuj_Studenta());
            hideSubmenu();
        }

        #endregion

        private void button_kursy_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_kursmenu);
        }

        #region Kursy


        private void button_kursy_nowykurs_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new Kursy());
        }

        private void button_kursy_zarzadzaj_Click(object sender, EventArgs e)
        {
            openChildForm(new ZarzadzajKursy());
            hideSubmenu();
        }

        private void button_kursy_drukuj_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new KursyDrukuj());
        }
        #endregion Kursy

        private void button_oceny_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_ocenamenu);
        }

        #region Oceny

        private void button_oceny_nowaOcena_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new Oceny());
        }

        private void button_oceny_zarzadzaj_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new ZarzadzajOceny());
        }

        private void button_oceny_drukuj_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new OcenyDrukuj());
        }

        #endregion Oceny

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_StronaGlowna_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            licznikstudent();

        }

        private void label_WszystkichStudentow_Click(object sender, EventArgs e)
        {

        }

        private void button_wyloguj_Click(object sender, EventArgs e)
        {
            Logowanie login = new Logowanie();
            this.Hide();
            login.Show();
        }

        private void StronaGlowna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_kobiet2.Text =student.exeCount("SELECT COUNT(*) FROM student INNER JOIN oceny ON oceny.StudentId = student.StudentId WHERE oceny.NazwaKursu = '" + comboBox1.Text + "' AND student.StdPlec = 'Kobieta'");
            label_mezczyzn2.Text =student.exeCount("SELECT COUNT(*) FROM student INNER JOIN oceny ON oceny.StudentId = student.StudentId WHERE oceny.NazwaKursu='"+comboBox1.Text+"' AND student.StdPlec ='Mężczyzna'");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_kalendarzyk_Tick(object sender, EventArgs e)
        {
            label_kalendarz_time.Text=DateTime.Now.ToLongTimeString();
            label3_kalendarz_data.Text=DateTime.Now.ToLongDateString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label_mezczyzn2_Click(object sender, EventArgs e)
        {

        }

        private void label_kobiet2_Click(object sender, EventArgs e)
        {

        }

        private void button_kalkulator_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_witaj_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void chart()
        {
            chart1.Series["men"].Points.AddXY("Kobiety", student.liczbaKobietStudent());
            chart1.Series["men"].Points.AddXY("Mezczyzni", student.liczbaMezczyznStudent());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel_g.BackColor == Color.Brown)
            {
                panel_g.BackColor=Color.FromArgb(24, 30, 54);
                button_kalkulator.BackColor = Color.FromArgb(24, 30, 54);
                button_StronaGlowna.BackColor = Color.FromArgb(24, 30, 54);
            }
            else
            {
                panel_g.BackColor = Color.Brown;
                button_kalkulator.BackColor = Color.Brown;
                button_StronaGlowna.BackColor = Color.Brown;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openChildForm(new Przegladarka());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:youremail@xx.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:youremail@xx.com");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:youremail@xx.com");
        }
    }
}
