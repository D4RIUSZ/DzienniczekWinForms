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
using DGVPrinterHelper;

namespace Dzienniczekv2
{
    public partial class Drukuj_Studenta : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter printer = new DGVPrinter();
        public Drukuj_Studenta()
        {
            InitializeComponent();
        }

        private void Drukuj_Studenta_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM student"));
         
        }
        public void showData(MySqlCommand command)
        {
            DataGridViewStudent.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridViewStudent.DataSource = student.getList(command);
            
            imageColumn = (DataGridViewImageColumn)DataGridViewStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if(radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM student";
            }
            else if(radioButton_men.Checked)
            {
                selectQuery = "SELECT * FROM student WHERE StdPlec='Mężczyzna'";
            }
            else
            {
                selectQuery = "SELECT * FROM student WHERE StdPlec='Kobieta'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button_drukuj_Click(object sender, EventArgs e)
        {
            printer.Title = "Lista Studentów";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridViewStudent);
        }

        private void label_plec_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_men_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio()
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM student";
            }
            else if (radioButton_men.Checked)
            {
                selectQuery = "SELECT * FROM student WHERE StdPlec='Mężczyzna'";
            }
            else
            {
                selectQuery = "SELECT * FROM student WHERE StdPlec='Kobieta'";
            }
            showData(new MySqlCommand(selectQuery));
        }
    }
}
