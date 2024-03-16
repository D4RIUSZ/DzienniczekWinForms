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
    public partial class KursyDrukuj : Form
    {
        KursyClass kurs = new KursyClass();
        DGVPrinter printer = new DGVPrinter();
        public KursyDrukuj()
        {
            InitializeComponent();
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            DataGridView_Kursy.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy` WHERE CONCAT(`Nazwa Kursu`)LIKE '%" + textBox_szukajKurs.Text + "%'"));
            textBox_szukajKurs.Clear();
        }

        private void KursyDrukuj_Load(object sender, EventArgs e)
        {
            DataGridView_Kursy.DataSource = kurs.getKurs(new MySqlCommand("SELECT * FROM `kursy`"));
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
            printer.PrintDataGridView(DataGridView_Kursy);
        }
    }
}
