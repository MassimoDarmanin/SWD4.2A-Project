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
using DGVPrinterHelper; //outsourced class for printing

namespace AutoPartsManagementSystem
{
    public partial class ManagerMain : Form
    {
        //
        SqlConnection con = new SqlConnection(Program.host); //DB source
        //

        //
        double value, amount, quantity, totalP;
        //

        public ManagerMain()
        {
            InitializeComponent();
        }


        private void logBtn_Click(object sender, EventArgs e) //logout btn
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
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

        private void filterBtn_Click(object sender, EventArgs e) //Opens Filter Form
        {
            FilterItems fi = new FilterItems();
            fi.Show();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            /*newinvoice ni = new newinvoice();
            ni.Show();*/

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

        /*private void ManagerMain_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            String sqlSelectQuery = "SELECT * FROM Users,Managers WHERE Username= '" + LoginForm.user +"'";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                nLabel.Text = (sdr["ManagerName"].ToString());
                sLabel.Text = (sdr["ManagerSurname"].ToString());
                con.Close();
            }
            con.Close();
        }*/

        public void addMethod()//Getting total value
        {
            value = Convert.ToDouble(valueBox.Text);
            quantity = Convert.ToDouble(quantityBox.Text);
            amount = value * quantity;
            totalP += amount;
            amountLbl.Text = totalP.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (quantityBox.Text == "" || searchBox.Text == "")//add btn validation
            {
                MessageBox.Show("Please input both quantity & Part No.");
            }
            else
            {
                int myInt;
                bool isNumerical = int.TryParse(quantityBox.Text, out myInt); //if text inputted == number

                if (isNumerical == true)
                {
                    //Getting total value
                    addMethod();

                    //updating grid
                    Grid1.Rows.Add(searchBox.Text, nameBox.Text, valueBox.Text, quantityBox.Text, amount);
                }
                else
                {
                    MessageBox.Show("Please input only integers");
                }
                    
            }
        }

        private void editBtn_Click(object sender, EventArgs e) //loads CRUD forms
        {
            if (crudBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Table to edit.");
            }
            else if (crudBox.SelectedItem.ToString() == "Usernames")
            {
                UsersCrud uc = new UsersCrud();
                uc.Show();
            }
            else if (crudBox.SelectedItem.ToString() == "Items")
            {
                ItemCrud ic = new ItemCrud();
                ic.Show();
            }
            else if (crudBox.SelectedItem.ToString() == "Clients")
            {
                ClientCrud cc = new ClientCrud();
                cc.Show();
            }
            else if (crudBox.SelectedItem.ToString() == "Others")
            {
                CrudForm cf = new CrudForm();
                cf.Show();
            }            
        }

        private void selBtn_Click(object sender, EventArgs e)//loads client detials
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
