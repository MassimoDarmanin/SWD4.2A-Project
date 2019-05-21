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
    public partial class ForgotPw : Form
    {
        SqlConnection con = new SqlConnection(Program.host);

        public ForgotPw()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Users, Employees, Managers WHERE Username='" + userBox.Text + "' AND Employees.EmployeeName='" + nameBox.Text +
                "' OR Username='" + userBox.Text + "' AND Managers.ManagerName='" + nameBox.Text + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Username or name incorrect");
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
                    pwBox.Text = (sdr["Password"].ToString());
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Username or Name incorrect");
                    pwBox.Text = "";
                    con.Close();
                }
            }
        }
    }
}
