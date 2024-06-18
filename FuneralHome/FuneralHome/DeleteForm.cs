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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = funeralHome;Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryStr = "SELECT Room FROM tblRoom;";
            var command = new SqlCommand(queryStr, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string roomString = reader["Room"].ToString();
                comboBox1.Items.Add(roomString);
            }

            reader.Close();
            connection.Close();

            connection.Open();
            queryStr = "SELECT Service FROM tblService;";
            command = new SqlCommand(queryStr, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string serviceString = reader["Service"].ToString();
                comboBox2.Items.Add(serviceString);
            }

            reader.Close();
            connection.Close();

            connection.Open();
            queryStr = "SELECT * FROM tblDecedent;";
            command = new SqlCommand(queryStr, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string family = reader["Family"].ToString();
                string first = reader["First"].ToString();
                string middle = reader["Middle"].ToString();
                string birthdate = reader["Birthdate"].ToString();
                string deathdate = reader["Deathdate"].ToString();
                string room = reader["Room"].ToString();
                string service = reader["Service"].ToString();
                string id = reader["DecedentID"].ToString();


                textBox1.Text = family;
                textBox2.Text = first;
                textBox3.Text = middle;
                textBox4.Text = id;
                dateTimePicker1.Text = birthdate;
                dateTimePicker2.Text = deathdate;
                comboBox1.Text = room;
                comboBox2.Text = service;
            }

            reader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Delete Decedent Information?", "Warning", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                string path = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = funeralHome;Integrated Security = True;";
                SqlConnection connection = new SqlConnection(path);
                connection.Open();
                string queryStr = "DELETE FROM tblDecedent WHERE DecedentID = @DecedentID";
                var command = new SqlCommand(queryStr, connection);

                SqlParameter param = new SqlParameter("@DecedentID", textBox4.Text);
                SqlParameter param1 = new SqlParameter("@Family", textBox1.Text);
                SqlParameter param2 = new SqlParameter("@First", textBox2.Text);
                SqlParameter param3 = new SqlParameter("@Middle", textBox3.Text);
                SqlParameter param4 = new SqlParameter("@Birthdate", Convert.ToDateTime(dateTimePicker1.Text));
                SqlParameter param5 = new SqlParameter("@Deathdate", Convert.ToDateTime(dateTimePicker2.Text));
                SqlParameter param6 = new SqlParameter("@Room", comboBox1.Text);
                SqlParameter param7 = new SqlParameter("@Service", comboBox2.Text);

                command = new SqlCommand(queryStr, connection);
                command.Parameters.Add(param);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);
                command.Parameters.Add(param5);
                command.Parameters.Add(param6);
                command.Parameters.Add(param7);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Decedent Information has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
