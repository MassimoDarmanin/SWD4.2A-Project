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
    public partial class FilterItems : Form
    {
        SqlConnection con = new SqlConnection(Program.host); //DB source
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable table;

        public FilterItems()
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


        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBox.SelectedItem.ToString() == "Categories")
            {
                int val;
                Int32.TryParse(selectBox.SelectedValue.ToString(), out val);
                string query = "SELECT PartID, PartNO, PartName, PartValue, PartDescription FROM Parts WHERE Parts.CategoryID LIKE " + val;
                Grid1.DataSource = getData(query);
            }
            else if (filterBox.SelectedItem.ToString() == "Make")
            {
                int val;
                Int32.TryParse(selectBox.SelectedValue.ToString(), out val);
                string query = "SELECT PartID,PartNO, PartName, PartValue, PartDescription FROM Parts WHERE Parts.MakeID LIKE " + val;
                Grid1.DataSource = getData(query);
            }
            else if (filterBox.SelectedItem.ToString() == "Model")
            {
                int val;
                Int32.TryParse(selectBox.SelectedValue.ToString(), out val);
                string query = "SELECT PartID,PartNo,PartName, PartValue, PartDescription FROM Parts WHERE Parts.ModelID LIKE " + val;
                Grid1.DataSource = getData(query);
            }
            else
            {
                MessageBox.Show("Please Select both dropdown options");
            }
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBox.SelectedItem.ToString() == "Categories")
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                selectBox.DataSource = getData(query);
                selectBox.DisplayMember = "CategoryName";
                selectBox.ValueMember = "CategoryID";

                selectBox_SelectedIndexChanged(null, null);
            }
            else if (filterBox.SelectedItem.ToString() == "Make")
            {
                string query = "SELECT MakeID, MakeName FROM Make";
                selectBox.DataSource = getData(query);
                selectBox.DisplayMember = "MakeName";
                selectBox.ValueMember = "MakeID";

                selectBox_SelectedIndexChanged(null, null);
            }
            else if (filterBox.SelectedItem.ToString() == "Model")
            {
                string query = "SELECT ModelID, ModelName FROM Model";
                selectBox.DataSource = getData(query);
                selectBox.DisplayMember = "ModelName";
                selectBox.ValueMember = "ModelID";

                selectBox_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Please Select Filter from drop down");
            }
        }
    }
}
