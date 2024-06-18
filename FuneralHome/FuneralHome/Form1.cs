using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FuneralHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decedentMasterlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecedentMasterlist aForm = new DecedentMasterlist();
            aForm.Show();
        }

        private void addDecedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDecedent aForm = new NewDecedent();
            aForm.Show();
        }
    }
}
