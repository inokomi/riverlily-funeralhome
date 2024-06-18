using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralHome
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
            
        }
            int counter = 0;
        private void Splash_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter == 20)
            {            
                timer1.Stop();
                Form1 aForm = new Form1();
                aForm.Show();
                Hide();
            }
        }
    }
}
