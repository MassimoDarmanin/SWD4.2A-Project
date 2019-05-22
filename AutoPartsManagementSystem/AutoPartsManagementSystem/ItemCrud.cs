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
    public partial class ItemCrud : Form
    {

        SqlConnection con = new SqlConnection(Program.host); //DB source
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable table;

        //
        string filename;
        //List<Image> list;

        public ItemCrud()
        {
            InitializeComponent();
            DisplayData(); //used to display table on the grid
        }

        //responsible for opening and closing db connection
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

        //avoids repeating code by passing each query through the same function
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            int myInt;
            bool isNumerical = int.TryParse(noBox.Text, out myInt);

            if (isNumerical == true)
            {
                String sqlSelectQuery = "SELECT * FROM Parts WHERE PartID = " + myInt;
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    nameBox.Text = (sdr["PartName"].ToString());
                    valueBox.Text = (sdr["PartValue"].ToString());
                    descBox.Text = (sdr["PartDescription"].ToString());

                    modelBox.Text = (sdr["ModelID"].ToString());
                    catBox.Text = (sdr["CategoryID"].ToString());
                    makeBox.Text = (sdr["MakeID"].ToString());

                    //
                    //


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

        /* //converting image to binary
        byte[] ConvertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        } */

        private void insBtn_Click(object sender, EventArgs e)
        {
            string insQuery = "INSERT INTO Parts (PartNo, PartName, PartValue, PartDescription, ModelID, CategoryID) VALUES ('" + noBox.Text + "','" + nameBox.Text + "','" + valueBox.Text + "','" + descBox.Text + "','" + modelBox.Text + "','" + catBox.Text + "')";
            doQuery(insQuery);
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            string upQuery = "UPDATE Parts SET PartNo='" + noBox.Text + "', PartName='" + nameBox.Text + "', PartValue='" + valueBox.Text + "', PartDescription='" + descBox.Text + "', Parts.MakeID='" + makeBox.Text + "', Parts.ModelID='" + modelBox.Text + "', Parts.CategoryID='" + catBox.Text +"' WHERE PartID=" + noBox.Text;
            doQuery(upQuery);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string delQuery = "DELETE FROM Parts WHERE PartNo=" + noBox.Text;
            doQuery(delQuery);
        }

        //sets what to display on grid
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM Parts", con);
            sda.Fill(dt);
            Grid1.DataSource = dt;
        }

        //query
        public DataTable getData(string query)
        {

            command = new SqlCommand(query, con);
            sda = new SqlDataAdapter(command);
            table = new DataTable();
            sda.Fill(table);
            return table;

        }

        //clears text
        private void ClearData()
        {
            noBox.Text = "";
            nameBox.Text = "";
            valueBox.Text = "";
            descBox.Text = "";
            modelBox.Text = "";
            catBox.Text = "";
            makeBox.Text = "";
        }

        private void picBtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="JPEG|*.jpg", ValidateNames=true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName.ToString();
                    pictureBox.ImageLocation = filename;
                }
            }
        }

        private void saveImgBtn_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            image = brs.ReadBytes((int)stream.Length);

            con.Open();
            string imgQuery = "UPDATE Parts SET Image = @image WHERE PartID="+ noBox.Text;
            command = new SqlCommand(imgQuery, con);
            command.Parameters.Add(new SqlParameter("@image", image));
            int n = command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(n.ToString()+"Data saved");
            DisplayData();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            TableofContent fi = new TableofContent();
            fi.Show();
        }

        /*private void makeBox_SelectedIndexChanged(object sender, EventArgs e)//fills cBox according to previous cBox
        {
            int choice = makeBox.SelectedIndex + 1;

            string query = "SELECT ModelID, ModelName FROM Model WHERE MakeID=" + choice;
            modelBox.DataSource = getData(query);
            modelBox.DisplayMember = "ModelName";
            modelBox.ValueMember = "ModelID";

            modelBox_SelectionChangeCommitted(null, null); //changed from SelectedIndexChanged to avoid error
        }

        private void ItemCrud_Load(object sender, EventArgs e) //fills cBox from DB
        {
            string query1 = "SELECT MakeID, MakeName FROM Make";
            makeBox.DataSource = getData(query1);
            makeBox.DisplayMember = "MakeName";
            makeBox.ValueMember = "MakeID";

            makeBox_SelectedIndexChanged(null, null);

            string query2 = "SELECT CategoryID, CategoryName FROM Categories";
            catBox.DataSource = getData(query2);
            catBox.DisplayMember = "CategoryName";
            catBox.ValueMember = "CategoryID";

            catBox_SelectedIndexChanged(null, null);
        }

        private void modelBox_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            
        }

        private void catBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
        //Used comboboxes to limit user error but had a conflicting connection error I couldn't resolve
    }
}
