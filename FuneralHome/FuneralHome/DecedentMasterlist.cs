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
    public partial class DecedentMasterlist : Form
    {
        public DecedentMasterlist()
        {
            InitializeComponent();
        }

        private void DecedentMasterlist_Load(object sender, EventArgs e)
        {
            string path = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = funeralHome; Integrated Security = True;";
            SqlConnection connection = new SqlConnection(path);
            connection.Open();
            string queryString = "SELECT * FROM tblDecedent ORDER BY Family";

            SqlCommand command = new SqlCommand(queryString, connection);
            var read = command.ExecuteReader();
            while (read.Read())
            {
                string id = read["DecedentID"].ToString();
                string family = read["Family"].ToString();
                string first = read["First"].ToString();
                string middle = read["Middle"].ToString();
                string birthdate = read["Birthdate"].ToString();
                string deathdate = read["Deathdate"].ToString();
                string room = read["Room"].ToString();
                string service = read["Service"].ToString();
                

                ListViewItem items = new ListViewItem(id);
                items.SubItems.Add(family);
                items.SubItems.Add(first);
                items.SubItems.Add(middle);
                items.SubItems.Add(birthdate);
                items.SubItems.Add(deathdate);
                items.SubItems.Add(room);
                items.SubItems.Add(service);
                listView1.Items.Add(items);
            }

            read.Close();
            connection.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm aForm = new EditForm();
            aForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm aForm = new DeleteForm();
            aForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
