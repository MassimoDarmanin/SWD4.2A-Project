namespace AutoPartsManagementSystem
{
    partial class CrudForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.insBtn = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.ToolTip(this.components);
            this.insert = new System.Windows.Forms.ToolTip(this.components);
            this.delete = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(376, 116);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 20);
            this.nameBox.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Name:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(107, 116);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(156, 20);
            this.idBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(188, 161);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 45;
            this.delBtn.Text = "Delete";
            this.delete.SetToolTip(this.delBtn, "Select only the ID field to select which row to delete");
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(107, 161);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 44;
            this.updBtn.Text = "Update";
            this.update.SetToolTip(this.updBtn, "When Updating, Select field from the ID field and whatever other field needs to b" +
        "e updated");
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // Grid1
            // 
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(26, 196);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(506, 242);
            this.Grid1.TabIndex = 43;
            // 
            // insBtn
            // 
            this.insBtn.Location = new System.Drawing.Point(26, 161);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(75, 23);
            this.insBtn.TabIndex = 42;
            this.insBtn.Text = "Insert";
            this.insert.SetToolTip(this.insBtn, "When Inserting a new entry, Fill only the Name (& MakeID if promted) fields.");
            this.insBtn.UseVisualStyleBackColor = true;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Categories",
            "Make",
            "Model"});
            this.typeBox.Location = new System.Drawing.Point(107, 54);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(156, 21);
            this.typeBox.TabIndex = 52;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Choose type:";
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(376, 158);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(156, 20);
            this.makeBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Make ID:";
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.insBtn);
            this.Name = "CrudForm";
            this.Text = "CrudForm";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button insBtn;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip delete;
        private System.Windows.Forms.ToolTip update;
        private System.Windows.Forms.ToolTip insert;
    }
}