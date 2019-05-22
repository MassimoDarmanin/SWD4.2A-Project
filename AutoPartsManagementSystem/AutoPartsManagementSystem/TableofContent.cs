using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsManagementSystem
{
    public partial class TableofContent : Form
    {
        SqlConnection con = new SqlConnection(Program.host); //DB source
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable table;

        public TableofContent()
        {
            InitializeComponent();
        }

        public DataTable getData(string query)
        {

            command = new SqlCommand(query, con);
            sda = new SqlDataAdapter(command);
            table = new DataTable();
            sda.Fill(table);
            return table;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Category")
            {
                string query = "SELECT * FROM Categories";
                Grid1.DataSource = getData(query);
            }
            else if (comboBox1.SelectedItem.ToString() == "Make")
            {
                string query = "SELECT * FROM Make";
                Grid1.DataSource = getData(query);
            }
            else if (comboBox1.SelectedItem.ToString() == "Model")
            {
                string query = "SELECT * FROM Model";
                Grid1.DataSource = getData(query);
            }
            else
            {
                MessageBox.Show("Please Select from dropdown options");
            }
        }
    }
}
