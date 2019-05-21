namespace AutoPartsManagementSystem
{
    partial class ClientCrud
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
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.insBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(407, 70);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(156, 20);
            this.surnameBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Surname:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(189, 117);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 17;
            this.delBtn.Text = "Delete";
            this.toolTip3.SetToolTip(this.delBtn, "Select which Row to delete by filling the ID field");
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(108, 117);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 16;
            this.updBtn.Text = "Update";
            this.toolTip2.SetToolTip(this.updBtn, "Select Row from the ID field and fill whatever Field needs updating");
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // insBtn
            // 
            this.insBtn.Location = new System.Drawing.Point(27, 117);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(75, 23);
            this.insBtn.TabIndex = 14;
            this.insBtn.Text = "Insert";
            this.toolTip1.SetToolTip(this.insBtn, "Leave ID field empty and fill only Name & Surname Fields");
            this.insBtn.UseVisualStyleBackColor = true;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(109, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 20);
            this.nameBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(27, 175);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(606, 242);
            this.Grid1.TabIndex = 20;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(109, 23);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(156, 20);
            this.idBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID:";
            // 
            // ClientCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(672, 429);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.insBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "ClientCrud";
            this.Text = "ClientCrud";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button insBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}