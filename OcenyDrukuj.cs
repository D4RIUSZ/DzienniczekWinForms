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
using DGVPrinterHelper;

namespace Dzienniczekv2
{
    public partial class OcenyDrukuj : Form
    {
        OcenyClass ocena1 = new OcenyClass();
        DGVPrinter printer = new DGVPrinter(); 
        public OcenyDrukuj()
        {
            InitializeComponent();
        }

        private void DataGridView_Oceny_Click(object sender, EventArgs e)
        {

        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            DataGridView_Oceny.DataSource = ocena1.getList(new MySqlCommand("SELECT oceny.StudentId, student.StdImie, student.StdNazwisko, oceny.NazwaKursu, oceny.Ocena, oceny.Opis FROM student INNER JOIN oceny ON oceny.StudentId=student.StudentId WHERE CONCAT(student.StdImie,student.StdNazwisko,oceny.NazwaKursu)LIKE '%" + textBox_szukajOceny.Text + "%'"));
        }

        private void DataGridView_Oceny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_drukuj_Click(object sender, EventArgs e)
        {
            printer.Title = "Lista Ocen";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_Oceny);
        }

        private void OcenyDrukuj_Load(object sender, EventArgs e)
        {
            ShowOceny();
        }

        public void ShowOceny()
        {
            DataGridView_Oceny.DataSource = ocena1.getList(new MySqlCommand("SELECT oceny.StudentId, student.StdImie, student.StdNazwisko, oceny.NazwaKursu, oceny.Ocena, oceny.Opis FROM student INNER JOIN oceny ON oceny.StudentId=student.StudentId"));
        }

        private void textBox_szukajOceny_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
