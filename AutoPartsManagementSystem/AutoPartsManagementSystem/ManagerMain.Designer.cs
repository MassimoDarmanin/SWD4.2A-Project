namespace AutoPartsManagementSystem
{
    partial class ManagerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cSurnameBox = new System.Windows.Forms.Label();
            this.cNameBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.selBtn = new System.Windows.Forms.Button();
            this.crudBox = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descBox = new System.Windows.Forms.Label();
            this.makeBox = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.modelBox = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.endBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.topLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(40, 12);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(75, 23);
            this.logBtn.TabIndex = 12;
            this.logBtn.Text = "Log Out";
            this.toolTip5.SetToolTip(this.logBtn, "Redirect to login screen");
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.amountLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.filterBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Grid1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 582);
            this.panel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.cSurnameBox);
            this.panel5.Controls.Add(this.cNameBox);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.clientBox);
            this.panel5.Controls.Add(this.selBtn);
            this.panel5.Controls.Add(this.crudBox);
            this.panel5.Controls.Add(this.editBtn);
            this.panel5.Controls.Add(this.logBtn);
            this.panel5.Location = new System.Drawing.Point(636, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 554);
            this.panel5.TabIndex = 56;
            // 
            // cSurnameBox
            // 
            this.cSurnameBox.AutoSize = true;
            this.cSurnameBox.Location = new System.Drawing.Point(66, 297);
            this.cSurnameBox.Name = "cSurnameBox";
            this.cSurnameBox.Size = new System.Drawing.Size(24, 13);
            this.cSurnameBox.TabIndex = 25;
            this.cSurnameBox.Text = "n/a";
            // 
            // cNameBox
            // 
            this.cNameBox.AutoSize = true;
            this.cNameBox.Location = new System.Drawing.Point(66, 272);
            this.cNameBox.Name = "cNameBox";
            this.cNameBox.Size = new System.Drawing.Size(24, 13);
            this.cNameBox.TabIndex = 24;
            this.cNameBox.Text = "n/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Client ID:";
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(17, 202);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(121, 20);
            this.clientBox.TabIndex = 18;
            // 
            // selBtn
            // 
            this.selBtn.Location = new System.Drawing.Point(40, 237);
            this.selBtn.Name = "selBtn";
            this.selBtn.Size = new System.Drawing.Size(75, 23);
            this.selBtn.TabIndex = 15;
            this.selBtn.Text = "Select";
            this.toolTip3.SetToolTip(this.selBtn, "Select Client ID to appear on invoice");
            this.selBtn.UseVisualStyleBackColor = true;
            this.selBtn.Click += new System.EventHandler(this.selBtn_Click);
            // 
            // crudBox
            // 
            this.crudBox.FormattingEnabled = true;
            this.crudBox.Items.AddRange(new object[] {
            "Usernames",
            "Items",
            "Others",
            "Clients"});
            this.crudBox.Location = new System.Drawing.Point(17, 487);
            this.crudBox.Name = "crudBox";
            this.crudBox.Size = new System.Drawing.Size(121, 21);
            this.crudBox.TabIndex = 14;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(40, 514);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Edit";
            this.toolTip1.SetToolTip(this.editBtn, "Choose from dropdown list what to edit");
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amountLbl.Location = new System.Drawing.Point(344, 290);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(13, 13);
            this.amountLbl.TabIndex = 55;
            this.amountLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(265, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total Amount:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.searchBox);
            this.panel3.Location = new System.Drawing.Point(17, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 66);
            this.panel3.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part no.";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(453, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 40);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.searchBtn, "Search for a specific part number.");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(124, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(287, 20);
            this.searchBox.TabIndex = 1;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(470, 286);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 21);
            this.filterBtn.TabIndex = 53;
            this.filterBtn.Text = "Filter";
            this.toolTip4.SetToolTip(this.filterBtn, "Opens a new window in order to filter and search for a specific item");
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.descBox);
            this.panel2.Controls.Add(this.makeBox);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.modelBox);
            this.panel2.Controls.Add(this.quantityBox);
            this.panel2.Controls.Add(this.valueBox);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(17, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 188);
            this.panel2.TabIndex = 50;
            // 
            // descBox
            // 
            this.descBox.AutoSize = true;
            this.descBox.Location = new System.Drawing.Point(121, 163);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(24, 13);
            this.descBox.TabIndex = 30;
            this.descBox.Text = "n/a";
            // 
            // makeBox
            // 
            this.makeBox.AutoSize = true;
            this.makeBox.Location = new System.Drawing.Point(121, 96);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(24, 13);
            this.makeBox.TabIndex = 29;
            this.makeBox.Text = "n/a";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(291, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(171, 143);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // modelBox
            // 
            this.modelBox.AutoSize = true;
            this.modelBox.Location = new System.Drawing.Point(121, 67);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(24, 13);
            this.modelBox.TabIndex = 28;
            this.modelBox.Text = "n/a";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(121, 122);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(121, 20);
            this.quantityBox.TabIndex = 15;
            // 
            // valueBox
            // 
            this.valueBox.AutoSize = true;
            this.valueBox.Location = new System.Drawing.Point(121, 45);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(24, 13);
            this.valueBox.TabIndex = 27;
            this.valueBox.Text = "n/a";
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(121, 14);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(24, 13);
            this.nameBox.TabIndex = 26;
            this.nameBox.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value (eu):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Part Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // Grid1
            // 
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.itemname,
            this.cost,
            this.itemquantity,
            this.total});
            this.Grid1.Location = new System.Drawing.Point(17, 315);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(563, 252);
            this.Grid1.TabIndex = 52;
            // 
            // partno
            // 
            this.partno.HeaderText = "Part No.";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // itemname
            // 
            this.itemname.HeaderText = "Item";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Value Each";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // itemquantity
            // 
            this.itemquantity.HeaderText = "Quantity";
            this.itemquantity.Name = "itemquantity";
            this.itemquantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Amount";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.endBtn);
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Location = new System.Drawing.Point(17, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 27);
            this.panel4.TabIndex = 51;
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(121, 3);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 21);
            this.endBtn.TabIndex = 51;
            this.endBtn.Text = "End Invoice";
            this.toolTip3.SetToolTip(this.endBtn, "Print Invoice");
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 21);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "Add";
            this.toolTip2.SetToolTip(this.addBtn, "Add entry to the invoice from the previously searched item above");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(12, 19);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(52, 13);
            this.topLabel.TabIndex = 12;
            this.topLabel.Text = "Welcome";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(70, 19);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(17, 13);
            this.nLabel.TabIndex = 13;
            this.nLabel.Text = "//";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(137, 19);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(17, 13);
            this.sLabel.TabIndex = 14;
            this.sLabel.Text = "//";
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 639);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox crudBox;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.Button selBtn;
        private System.Windows.Forms.Label cSurnameBox;
        private System.Windows.Forms.Label cNameBox;
        private System.Windows.Forms.Label makeBox;
        private System.Windows.Forms.Label modelBox;
        private System.Windows.Forms.Label valueBox;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Label descBox;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label sLabel;
    }
}