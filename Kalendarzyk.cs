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
    public partial class Kalendarzyk : Form
    {
        public Kalendarzyk()
        {
            InitializeComponent();
        }

        private void Kalendarzyk_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
