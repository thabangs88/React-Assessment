
namespace React
{
    partial class frmMain
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tAverage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Surname,
            this.Birthday});
            this.dgvPeople.Location = new System.Drawing.Point(12, 118);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(423, 176);
            this.dgvPeople.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 20;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 180;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(12, 34);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 1;
            this.bBrowse.Text = "Browse:";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(93, 36);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.ReadOnly = true;
            this.tFilePath.Size = new System.Drawing.Size(342, 20);
            this.tFilePath.TabIndex = 2;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(12, 89);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(423, 23);
            this.bCreate.TabIndex = 3;
            this.bCreate.Text = "Add New Person";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Date:";
            // 
            // lCurrentDate
            // 
            this.lCurrentDate.AutoSize = true;
            this.lCurrentDate.Location = new System.Drawing.Point(90, 9);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new System.Drawing.Size(98, 13);
            this.lCurrentDate.TabIndex = 5;
            this.lCurrentDate.Text = "22 November 2022";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(360, 9);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 6;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(12, 300);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age Average:";
            // 
            // tAverage
            // 
            this.tAverage.Location = new System.Drawing.Point(371, 297);
            this.tAverage.Name = "tAverage";
            this.tAverage.ReadOnly = true;
            this.tAverage.Size = new System.Drawing.Size(64, 20);
            this.tAverage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "1. First create an empty text file.\r\n2. Browse to the file";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 332);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.lCurrentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tFilePath);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.dgvPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Overview";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCurrentDate;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tAverage;
        private System.Windows.Forms.Label label2;
    }
}

