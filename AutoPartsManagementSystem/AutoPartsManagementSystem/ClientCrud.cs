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
    public partial class ClientCrud : Form
    {
        SqlConnection con = new SqlConnection(Program.host);
        SqlCommand command;
        SqlDataAdapter sda;

        public ClientCrud()
        {
            InitializeComponent();
            DisplayData();
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

        public void doQuery(String query)
        {
            try
            {
                openCon();
                command = new SqlCommand(query, con);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                    DisplayData();
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

        private void insBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || surnameBox.Text == "")
            {
                MessageBox.Show("Cannot leave fields empty");
            }
            else
            {
                string insQuery = "INSERT INTO Clients(ClientName, ClientSurname) VALUES ('" + nameBox.Text + "','" + surnameBox.Text + "')";
                doQuery(insQuery);
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please Select ID");
            }
            else
            {
                if (nameBox.Text == "" || surnameBox.Text == "")
                {
                    MessageBox.Show("Cannot leave fields empty");
                }
                else
                {
                    string upQuery = "UPDATE Clients SET ClientName='" + nameBox.Text + "', ClientSurname='" + surnameBox.Text + "' WHERE ClientID=" + idBox.Text;
                    doQuery(upQuery);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please Select ID");
            }
            else
            {
                string delQuery = "DELETE FROM Clients WHERE ClientID=" + idBox.Text;
                doQuery(delQuery);
            }
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM Clients", con);
            sda.Fill(dt);
            Grid1.DataSource = dt;
        }

        private void ClearData()
        {
            idBox.Text = "";
            nameBox.Text = "";
            surnameBox.Text = "";
        }
    }
}
