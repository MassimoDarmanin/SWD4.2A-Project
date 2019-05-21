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
    public partial class CrudForm : Form
    {

        SqlConnection con = new SqlConnection(Program.host);
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable table;

        public CrudForm()
        {
            InitializeComponent();

            makeBox.Visible = false;
            label3.Visible = false;
        }

        public void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable getData(string query)
        {

            command = new SqlCommand(query, con);
            sda = new SqlDataAdapter(command);
            table = new DataTable();
            sda.Fill(table);
            return table;
        }

        public void doQuery(String query)
        {
            try
            {
                openCon();
                command = new SqlCommand(query, con);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                    ClearData();
                    closeCon();
                }
                else
                {
                    MessageBox.Show("Query not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Choose from dropdown list");
            }
            else if (typeBox.SelectedItem.ToString() == "Categories")
            {
                makeBox.Visible = false;
                label3.Visible = false;

                string query = "SELECT * FROM Categories";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Make")
            {
                makeBox.Visible = false;
                label3.Visible = false;

                string query = "SELECT * FROM Make";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Model")
            {
                makeBox.Visible = true;
                label3.Visible = true;

                string query = "SELECT * FROM Model";
                Grid1.DataSource = getData(query);
            }
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Categories")
            {
                string insQuery = "INSERT INTO Categories(CategoryName) VALUES ('" + nameBox.Text + "')";
                doQuery(insQuery);

                string query = "SELECT * FROM Categories";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Make")
            {
                string insQuery = "INSERT INTO Make(MakeName) VALUES ('" + nameBox.Text + "')";
                doQuery(insQuery);

                string query = "SELECT * FROM Make";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Model")
            {
                string insQuery = "INSERT INTO Model(ModelName, MakeID) VALUES ('" + nameBox.Text + "','" + makeBox.Text + "')";
                doQuery(insQuery);

                string query = "SELECT * FROM Model";
                Grid1.DataSource = getData(query);
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Categories")
            {
                string upQuery = "UPDATE Categories SET CategoryName='" + nameBox.Text + "'WHERE CategoryID="+ idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Categories";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Make")
            {
                string upQuery = "UPDATE Make SET  MakeName='" + nameBox.Text + "'WHERE MakeID=" + idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Make";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Model")
            {
                string upQuery = "UPDATE Model SET ModelName='" + nameBox.Text + "', MakeID='" + makeBox.Text + "'WHERE ModelID=" + idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Model";
                Grid1.DataSource = getData(query);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Categories")
            {
                string delQuery = "DELETE FROM Categories WHERE CategoryID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Categories";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Make")
            {
                string delQuery = "DELETE FROM Make WHERE MakeID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Make";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Model")
            {
                string delQuery = "DELETE FROM Model WHERE ModelID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Model";
                Grid1.DataSource = getData(query);
            }
        }

        private void ClearData()
        {
            idBox.Text = "";
            nameBox.Text = "";
            makeBox.Text = "";
        }
    }
}
