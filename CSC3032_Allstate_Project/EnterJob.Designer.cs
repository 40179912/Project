﻿namespace CSC3032_Allstate_Project
{
    partial class EnterJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterJob));
            this.SectorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.JobDescTextBox = new System.Windows.Forms.TextBox();
            this.JobNameBox = new System.Windows.Forms.TextBox();
            this.AddJobBut = new System.Windows.Forms.Button();
            this.JobDescBox = new System.Windows.Forms.TextBox();
            this.EditJobBeneBtn = new System.Windows.Forms.Button();
            this.EnterBeneBtn = new System.Windows.Forms.Button();
            this.EditEmployBeneBtn = new System.Windows.Forms.Button();
            this.EnterEmpBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowSectorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearDatabaseBtn = new System.Windows.Forms.Button();
            this.ClearJobsBtn = new System.Windows.Forms.Button();
            this.SectorBox = new System.Windows.Forms.ComboBox();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.DeleteJobBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SectorTextBox
            // 
            this.SectorTextBox.Location = new System.Drawing.Point(123, 279);
            this.SectorTextBox.Multiline = true;
            this.SectorTextBox.Name = "SectorTextBox";
            this.SectorTextBox.Size = new System.Drawing.Size(252, 20);
            this.SectorTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Job Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Job Name";
            // 
            // JobDescTextBox
            // 
            this.JobDescTextBox.Location = new System.Drawing.Point(123, 328);
            this.JobDescTextBox.Multiline = true;
            this.JobDescTextBox.Name = "JobDescTextBox";
            this.JobDescTextBox.Size = new System.Drawing.Size(252, 121);
            this.JobDescTextBox.TabIndex = 10;
            // 
            // JobNameBox
            // 
            this.JobNameBox.Location = new System.Drawing.Point(123, 253);
            this.JobNameBox.Multiline = true;
            this.JobNameBox.Name = "JobNameBox";
            this.JobNameBox.Size = new System.Drawing.Size(252, 20);
            this.JobNameBox.TabIndex = 9;
            // 
            // AddJobBut
            // 
            this.AddJobBut.Location = new System.Drawing.Point(188, 456);
            this.AddJobBut.Name = "AddJobBut";
            this.AddJobBut.Size = new System.Drawing.Size(103, 23);
            this.AddJobBut.TabIndex = 49;
            this.AddJobBut.Text = "Add Job";
            this.AddJobBut.UseVisualStyleBackColor = true;
            this.AddJobBut.Click += new System.EventHandler(this.AddJobBut_Click);
            // 
            // JobDescBox
            // 
            this.JobDescBox.BackColor = System.Drawing.Color.White;
            this.JobDescBox.Location = new System.Drawing.Point(489, 307);
            this.JobDescBox.Multiline = true;
            this.JobDescBox.Name = "JobDescBox";
            this.JobDescBox.ReadOnly = true;
            this.JobDescBox.Size = new System.Drawing.Size(221, 142);
            this.JobDescBox.TabIndex = 53;
            // 
            // EditJobBeneBtn
            // 
            this.EditJobBeneBtn.Location = new System.Drawing.Point(261, 106);
            this.EditJobBeneBtn.Name = "EditJobBeneBtn";
            this.EditJobBeneBtn.Size = new System.Drawing.Size(137, 39);
            this.EditJobBeneBtn.TabIndex = 58;
            this.EditJobBeneBtn.Text = "Edit Job Benefits";
            this.EditJobBeneBtn.UseVisualStyleBackColor = true;
            this.EditJobBeneBtn.Click += new System.EventHandler(this.EditJobBeneBtn_Click);
            // 
            // EnterBeneBtn
            // 
            this.EnterBeneBtn.Location = new System.Drawing.Point(627, 106);
            this.EnterBeneBtn.Name = "EnterBeneBtn";
            this.EnterBeneBtn.Size = new System.Drawing.Size(111, 39);
            this.EnterBeneBtn.TabIndex = 57;
            this.EnterBeneBtn.Text = "Enter Benefit";
            this.EnterBeneBtn.UseVisualStyleBackColor = true;
            this.EnterBeneBtn.Click += new System.EventHandler(this.EnterBeneBtn_Click);
            // 
            // EditEmployBeneBtn
            // 
            this.EditEmployBeneBtn.Location = new System.Drawing.Point(34, 106);
            this.EditEmployBeneBtn.Name = "EditEmployBeneBtn";
            this.EditEmployBeneBtn.Size = new System.Drawing.Size(180, 39);
            this.EditEmployBeneBtn.TabIndex = 56;
            this.EditEmployBeneBtn.Text = "Edit Employee Benefits";
            this.EditEmployBeneBtn.UseVisualStyleBackColor = true;
            this.EditEmployBeneBtn.Click += new System.EventHandler(this.EditEmployBeneBtn_Click);
            // 
            // EnterEmpBtn
            // 
            this.EnterEmpBtn.Location = new System.Drawing.Point(444, 106);
            this.EnterEmpBtn.Name = "EnterEmpBtn";
            this.EnterEmpBtn.Size = new System.Drawing.Size(132, 39);
            this.EnterEmpBtn.TabIndex = 55;
            this.EnterEmpBtn.Text = "Enter Employee";
            this.EnterEmpBtn.UseVisualStyleBackColor = true;
            this.EnterEmpBtn.Click += new System.EventHandler(this.EnterEmpBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.ImageLocation = "https://logo-logos.com/wp-content/uploads/2016/10/Allstate_logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // ShowSectorBox
            // 
            this.ShowSectorBox.BackColor = System.Drawing.Color.White;
            this.ShowSectorBox.Location = new System.Drawing.Point(489, 280);
            this.ShowSectorBox.Multiline = true;
            this.ShowSectorBox.Name = "ShowSectorBox";
            this.ShowSectorBox.ReadOnly = true;
            this.ShowSectorBox.Size = new System.Drawing.Size(221, 28);
            this.ShowSectorBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.MaximumSize = new System.Drawing.Size(405, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 51);
            this.label4.TabIndex = 60;
            this.label4.Text = "To add a new job to the database: Enter in the name of the job, enter what sector" +
    " it is in (it can be in either a new sector or one that is already in the databa" +
    "se) and the job\'s description.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 168);
            this.label5.MaximumSize = new System.Drawing.Size(400, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 68);
            this.label5.TabIndex = 61;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // ClearDatabaseBtn
            // 
            this.ClearDatabaseBtn.Location = new System.Drawing.Point(703, 501);
            this.ClearDatabaseBtn.Name = "ClearDatabaseBtn";
            this.ClearDatabaseBtn.Size = new System.Drawing.Size(124, 25);
            this.ClearDatabaseBtn.TabIndex = 83;
            this.ClearDatabaseBtn.Text = "Clear Database";
            this.ClearDatabaseBtn.UseVisualStyleBackColor = true;
            this.ClearDatabaseBtn.Click += new System.EventHandler(this.ClearDatabaseBtn_Click);
            // 
            // ClearJobsBtn
            // 
            this.ClearJobsBtn.Location = new System.Drawing.Point(-2, 501);
            this.ClearJobsBtn.Name = "ClearJobsBtn";
            this.ClearJobsBtn.Size = new System.Drawing.Size(124, 25);
            this.ClearJobsBtn.TabIndex = 84;
            this.ClearJobsBtn.Text = "Clear Jobs";
            this.ClearJobsBtn.UseVisualStyleBackColor = true;
            this.ClearJobsBtn.Click += new System.EventHandler(this.ClearJobsBtn_Click);
            // 
            // SectorBox
            // 
            this.SectorBox.DropDownHeight = 67;
            this.SectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectorBox.FormattingEnabled = true;
            this.SectorBox.IntegralHeight = false;
            this.SectorBox.Location = new System.Drawing.Point(123, 298);
            this.SectorBox.Name = "SectorBox";
            this.SectorBox.Size = new System.Drawing.Size(252, 24);
            this.SectorBox.TabIndex = 87;
            // 
            // JobBox
            // 
            this.JobBox.DropDownHeight = 67;
            this.JobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobBox.FormattingEnabled = true;
            this.JobBox.IntegralHeight = false;
            this.JobBox.Location = new System.Drawing.Point(489, 257);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(221, 24);
            this.JobBox.TabIndex = 88;
            this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
            // 
            // DeleteJobBtn
            // 
            this.DeleteJobBtn.Location = new System.Drawing.Point(565, 456);
            this.DeleteJobBtn.Name = "DeleteJobBtn";
            this.DeleteJobBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteJobBtn.TabIndex = 92;
            this.DeleteJobBtn.Text = "Delete";
            this.DeleteJobBtn.UseVisualStyleBackColor = true;
            this.DeleteJobBtn.Click += new System.EventHandler(this.DeleteJobBtn_Click);
            // 
            // EnterJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 525);
            this.Controls.Add(this.DeleteJobBtn);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.SectorBox);
            this.Controls.Add(this.ClearJobsBtn);
            this.Controls.Add(this.ClearDatabaseBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowSectorBox);
            this.Controls.Add(this.EditJobBeneBtn);
            this.Controls.Add(this.EnterBeneBtn);
            this.Controls.Add(this.EditEmployBeneBtn);
            this.Controls.Add(this.EnterEmpBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JobDescBox);
            this.Controls.Add(this.AddJobBut);
            this.Controls.Add(this.SectorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JobDescTextBox);
            this.Controls.Add(this.JobNameBox);
            this.Name = "EnterJob";
            this.Text = "EnterJob";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JobDescTextBox;
        private System.Windows.Forms.TextBox JobNameBox;
        private System.Windows.Forms.Button AddJobBut;
        private System.Windows.Forms.TextBox JobDescBox;
        private System.Windows.Forms.Button EditJobBeneBtn;
        private System.Windows.Forms.Button EnterBeneBtn;
        private System.Windows.Forms.Button EditEmployBeneBtn;
        private System.Windows.Forms.Button EnterEmpBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ShowSectorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearDatabaseBtn;
        private System.Windows.Forms.Button ClearJobsBtn;
        private System.Windows.Forms.ComboBox SectorBox;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.Button DeleteJobBtn;
    }
}