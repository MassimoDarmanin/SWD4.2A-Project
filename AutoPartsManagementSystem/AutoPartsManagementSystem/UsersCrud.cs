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

namespace AutoPartsManagementSystem
{
    public partial class UsersCrud : Form
    {
        //
        SqlConnection con = new SqlConnection(Program.host);
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable table;
        //

        public UsersCrud()
        {
            InitializeComponent();
            DisplayData();

            // textboxes
            idBox.Visible = false;
            nameBox.Visible = false;
            surnameBox.Visible = false;
            userIDbox.Visible = false;
            userBox.Visible = false;
            pwBox.Visible = false;
            adminBox.Visible = false;

            // labels
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
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

        public DataTable getData(string query)
        {

            command = new SqlCommand(query, con);
            sda = new SqlDataAdapter(command);
            table = new DataTable();
            sda.Fill(table);
            return table;
        }

        //insert
        private void insBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Managers")
            {
                string insQuery = "INSERT INTO Managers(ManagerName, ManagerSurname, UserID) VALUES ('" + nameBox.Text + "','" +surnameBox.Text+ "','" +userIDbox.Text+ "')";
                doQuery(insQuery);

                string query = "SELECT * FROM Managers";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Employees")
            {
                string insQuery = "INSERT INTO Employees(EmployeeName, EmployeeSurname, UserID) VALUES ('" + nameBox.Text + "','" + surnameBox.Text + "','" + userIDbox.Text + "')";
                doQuery(insQuery);

                string query = "SELECT * FROM Employees";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Usernames")
            {
                if (adminBox.Text == "1" || adminBox.Text == "0")
                {

                    string insQuery = "INSERT INTO Users(Username, Password, AdminRights) VALUES ('" + userBox.Text + "','" + pwBox.Text + "','" + adminBox.Text + "')";
                    doQuery(insQuery);

                    string query = "SELECT * FROM Users";
                    Grid1.DataSource = getData(query);
                }
                else
                {
                    MessageBox.Show("Inputs should only consist of '1' or '0'");
                }
            }
        }

        //update
        private void updBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Managers")
            {
                string upQuery = "UPDATE Managers SET ManagerName='" + nameBox.Text + "', ManagerSurname='" +surnameBox.Text+ "', UserID='" +userIDbox.Text+ "'WHERE ManagerID=" + idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Managers";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Employees")
            {
                string upQuery = "UPDATE Employees SET EmployeeName='" + nameBox.Text + "', EmployeeSurname='" + surnameBox.Text + "', UserID='" + userIDbox.Text + "'WHERE EmployeeID=" + idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Employees";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Users")
            {
                string upQuery = "UPDATE Users SET Username='" + userBox.Text + "', Password='" + pwBox.Text + "', AdminRights='" + adminBox.Text + "'WHERE UserID=" + idBox.Text;
                doQuery(upQuery);

                string query = "SELECT * FROM Users";
                Grid1.DataSource = getData(query);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table");
            }
            else if (typeBox.SelectedItem.ToString() == "Managers")
            {
                string delQuery = "DELETE FROM Managers WHERE ManagerID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Managers";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Employees")
            {
                string delQuery = "DELETE FROM Employees WHERE EmployeeID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Employees";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Users")
            {
                string delQuery = "DELETE FROM Users WHERE UserID=" + idBox.Text;
                doQuery(delQuery);

                string query = "SELECT * FROM Users";
                Grid1.DataSource = getData(query);
            }
        }

        private void DisplayData() //updates grid
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM Employees", con);
            sda.Fill(dt);
            Grid1.DataSource = dt;
        }

        private void ClearData() //resets text
        {
            idBox.Text = "";
            nameBox.Text = "";
            surnameBox.Text = "";
            userBox.Text = "";
            pwBox.Text = "";
            userIDbox.Text = "";
            adminBox.Text = "";
        }

        private void ShowNames() //hides users' textboxes & labels
        {
            idBox.Visible = true;
            nameBox.Visible = true;
            surnameBox.Visible = true;
            userIDbox.Visible = true;

            label5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label7.Visible = true;

            //

            userBox.Visible = false;
            pwBox.Visible = false;
            adminBox.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void ShowUsers() //hides man/emp's textboxes & labels
        {
            idBox.Visible = true;
            userBox.Visible = true;
            pwBox.Visible = true;
            adminBox.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            //

            nameBox.Visible = false;
            surnameBox.Visible = false;
            userIDbox.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Please Choose From dropdown list");
            }
            else if (typeBox.SelectedItem.ToString() == "Managers")
            {
                ShowNames();

                string query = "SELECT * FROM Managers";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Employees")
            {
                ShowNames();

                string query = "SELECT * FROM Employees";
                Grid1.DataSource = getData(query);
            }
            else if (typeBox.SelectedItem.ToString() == "Usernames")
            {
                ShowUsers();

                string query = "SELECT * FROM Users";
                Grid1.DataSource = getData(query);
            }
        }
    }
}
