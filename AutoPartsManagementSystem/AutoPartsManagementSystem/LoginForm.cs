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
    public partial class LoginForm : Form
    {
        public static string user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setting Connection
            SqlConnection con = new SqlConnection(Program.host);

            //SQL 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Users WHERE Username='" + userBox.Text + "' and Password='" + pwBox.Text + "'", con); //1st query
            DataTable dt = new DataTable();
            con.Open();//opening for first query

            sda.Fill(dt);

            if (userBox.Text == "" || pwBox.Text == "")
            {
                MessageBox.Show("Enter Username & Password");
            }
            else
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Username or Password incorrect");
                    con.Close();
                }
                else
                {
                    con.Close();//closing for first query
                    con.Open();//opening for second query
                    String sqlSelectQuery = "SELECT * FROM Users WHERE Username = '" + userBox.Text + "'"; //2nd query
                    SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        bool type = ((bool)sdr["AdminRights"]);

                        if (type == true)
                        {
                            this.Hide();

                            ManagerMain mmp = new ManagerMain();
                            mmp.Show();
                            user = userBox.Text;
                            con.Close();
                        }
                        else
                        {
                            this.Hide();

                            EmployeeMain mmp = new EmployeeMain();
                            mmp.Show();
                            user = userBox.Text;
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password incorrect");
                        con.Close();
                    }

                }
            }

            
            //string UserType = typeBox.SelectedText; //getting data from cb
            //combobox validation
            /* if (typeBox.SelectedItem.ToString() == "Manager") { //for managers
                 //SQL 
                 SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Managers where ManagerUsername='" + userBox.Text + "' and ManagerPassword='" + pwBox.Text + "'", con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);

                 if (dt.Rows[0][0].ToString() == "1")
                 {
                     this.Hide();

                     ManagerMain mmp = new ManagerMain();
                     mmp.Show();
                 }
                 else
                 {
                     MessageBox.Show("Username or Password incorrect");
                 }
             }
             else if (typeBox.SelectedItem.ToString() == "Employee") //for employees
             {
                 //SQL 
                 SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Employees where EmployeeUsername='" + userBox.Text + "' and EmployeePassword='" + pwBox.Text + "'", con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);

                 if (dt.Rows[0][0].ToString() == "1")
                 {
                     this.Hide();

                     EmployeeMain emp = new EmployeeMain();
                     emp.Show();
                 }
                 else
                 {
                     MessageBox.Show("Username or Password incorrect");
                 }
             }
             else
             {
                 MessageBox.Show("Please Choose a user type");
             } */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPw fpw = new ForgotPw();
            fpw.Show();
        }
    }
}


