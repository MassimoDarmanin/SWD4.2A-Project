namespace AutoPartsManagementSystem
{
    partial class ItemCrud
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveImgBtn = new System.Windows.Forms.Button();
            this.picBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.noBox = new System.Windows.Forms.TextBox();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.insBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.makeBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.catBox = new System.Windows.Forms.TextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.filterBtn);
            this.panel2.Controls.Add(this.catBox);
            this.panel2.Controls.Add(this.modelBox);
            this.panel2.Controls.Add(this.makeBox);
            this.panel2.Controls.Add(this.saveImgBtn);
            this.panel2.Controls.Add(this.picBtn);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.descBox);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.valueBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 188);
            this.panel2.TabIndex = 6;
            // 
            // saveImgBtn
            // 
            this.saveImgBtn.Location = new System.Drawing.Point(598, 64);
            this.saveImgBtn.Name = "saveImgBtn";
            this.saveImgBtn.Size = new System.Drawing.Size(86, 24);
            this.saveImgBtn.TabIndex = 36;
            this.saveImgBtn.Text = "Save Image";
            this.toolTip5.SetToolTip(this.saveImgBtn, "Save Image to the current Part no. selected");
            this.saveImgBtn.UseVisualStyleBackColor = true;
            this.saveImgBtn.Click += new System.EventHandler(this.saveImgBtn_Click);
            // 
            // picBtn
            // 
            this.picBtn.Location = new System.Drawing.Point(598, 30);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(86, 24);
            this.picBtn.TabIndex = 35;
            this.picBtn.Text = "Choose picture";
            this.toolTip5.SetToolTip(this.picBtn, "Browse for a picture");
            this.picBtn.UseVisualStyleBackColor = true;
            this.picBtn.Click += new System.EventHandler(this.picBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(421, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(171, 143);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Make:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(121, 156);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(577, 20);
            this.descBox.TabIndex = 13;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 7);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(291, 20);
            this.nameBox.TabIndex = 10;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(121, 33);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(291, 20);
            this.valueBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value (eu):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 5);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.noBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 66);
            this.panel1.TabIndex = 5;
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
            this.searchBtn.Location = new System.Drawing.Point(753, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 40);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.searchBtn, "Search for a specific part number.");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // noBox
            // 
            this.noBox.Location = new System.Drawing.Point(124, 23);
            this.noBox.Name = "noBox";
            this.noBox.Size = new System.Drawing.Size(287, 20);
            this.noBox.TabIndex = 1;
            // 
            // Grid1
            // 
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(12, 308);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(887, 292);
            this.Grid1.TabIndex = 30;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(514, 278);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 34;
            this.delBtn.Text = "Delete";
            this.toolTip4.SetToolTip(this.delBtn, "Select which Row to delete by filling only the Part no. field");
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(433, 278);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 33;
            this.updBtn.Text = "Update";
            this.toolTip3.SetToolTip(this.updBtn, "Select Row from the Part no.  field and fill whatever Field needs updating");
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // insBtn
            // 
            this.insBtn.Location = new System.Drawing.Point(352, 278);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(75, 23);
            this.insBtn.TabIndex = 32;
            this.insBtn.Text = "Insert";
            this.toolTip2.SetToolTip(this.insBtn, "Leave Part no. field empty and fill only the rest of the Fields");
            this.insBtn.UseVisualStyleBackColor = true;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(120, 76);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(291, 20);
            this.makeBox.TabIndex = 39;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(120, 102);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(291, 20);
            this.modelBox.TabIndex = 40;
            // 
            // catBox
            // 
            this.catBox.Location = new System.Drawing.Point(120, 127);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(291, 20);
            this.catBox.TabIndex = 41;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(753, 155);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 21);
            this.filterBtn.TabIndex = 54;
            this.filterBtn.Text = "Filter";
            this.toolTip1.SetToolTip(this.filterBtn, "Opens a new window in order to filter and search for a specific item");
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // ItemCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(923, 612);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.insBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid1);
            this.Name = "ItemCrud";
            this.Text = "ItemCrud";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox noBox;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button insBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button picBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button saveImgBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.TextBox catBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.Button filterBtn;
    }
}