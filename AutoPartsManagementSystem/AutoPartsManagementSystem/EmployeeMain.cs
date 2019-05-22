using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsManagementSystem
{
    public partial class EmployeeMain : Form
    {
        //
        SqlConnection con = new SqlConnection(Program.host); //DB source
        //

        //
        double value, amount, quantity, totalP;
        //

        public EmployeeMain()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            int myInt;
            bool isNumerical = int.TryParse(searchBox.Text, out myInt); //if text inputted == number

            if (isNumerical == true)
            {

                String sqlSelectQuery = "SELECT * FROM Parts, Make, Model, Categories WHERE PartID = " + myInt;
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    nameBox.Text = (sdr["PartName"].ToString());
                    valueBox.Text = (sdr["PartValue"].ToString());
                    makeBox.Text = (sdr["MakeName"].ToString());
                    modelBox.Text = (sdr["ModelName"].ToString());
                    descBox.Text = (sdr["PartDescription"].ToString());

                    //load image
                    byte[] image = (byte[])(sdr["Image"]);
                    if (image == null)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream memstr = new MemoryStream(image);
                        pictureBox.Image = System.Drawing.Image.FromStream(memstr);
                    }
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Please enter integers only");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (quantityBox.Text == "" || searchBox.Text == "")//add btn validation
            {
                MessageBox.Show("Please input both quantity & Part No.");
            }
            else
            {
                //Getting total value
                value = Convert.ToDouble(valueBox.Text);
                quantity = Convert.ToDouble(quantityBox.Text);
                amount = value * quantity;
                totalP += amount;
                amountLbl.Text = totalP.ToString();


                //updating grid
                Grid1.Rows.Add(searchBox.Text, nameBox.Text, valueBox.Text, quantityBox.Text, amount);
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "AutoParts Receipt";
            if (clientBox == null)
            {
                print.SubTitle = string.Format(DateTime.Now.ToString("d/M/yyyy HH:mm:ss") + "|| Total amount: Eu" + totalP);
            }
            else
            {
                string cl = cNameBox.Text + " " + cSurnameBox.Text + " | ";
                print.SubTitle = cl + string.Format(DateTime.Now.ToString("d/M/yyyy HH:mm:ss") + "|| Total amount: Eu" + totalP);
            }


            print.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PorportionalColumns = true;
            //print.Footer = "Total amount: Eu" + totalP;
            print.PageNumbers = false;
            print.PrintDataGridView(Grid1);
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fi = new LoginForm();
            fi.Show();
        }

        /*private void EmployeeMain_Load(object sender, EventArgs e)
        {
            String sqlSelectQuery = "SELECT EmployeeName, EmployeeSurname FROM Employees, Users WHERE Users.UserName= ";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                topLabel.Text = (sdr["PartName"].ToString());
            }
        }*/

        private void filterBtn_Click(object sender, EventArgs e)
        {
            FilterItems fi = new FilterItems();
            fi.Show();
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            ClientCrud cc = new ClientCrud();
            cc.Show();
        }

        private void selBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            int myInt;
            bool isNumerical = int.TryParse(clientBox.Text, out myInt); //if text inputted == number

            if (isNumerical == true)
            {

                String sqlSelectQuery = "SELECT * FROM Clients WHERE ClientID = " + myInt;
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    cNameBox.Text = (sdr["ClientName"].ToString());
                    cSurnameBox.Text = (sdr["ClientSurname"].ToString());
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Please enter integers only");
            }
        }
    }
}
