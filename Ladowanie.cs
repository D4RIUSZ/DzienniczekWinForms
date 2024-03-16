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
    public partial class Ladowanie : Form
    {
        public Ladowanie()
        {
            InitializeComponent();
        }

        private void Ladowanie_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startprogress = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startprogress += 1;
            progressBar1.Increment(startprogress);
            if (startprogress >50)
            {
                Logowanie login = new Logowanie();
                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
