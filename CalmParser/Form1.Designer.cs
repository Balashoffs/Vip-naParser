﻿namespace VipassanaParser
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.checkedListBoxStudentInfo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxStudentType = new System.Windows.Forms.CheckedListBox();
            this.panelConnect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(5, 5);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(256, 27);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Login";
            // 
            // textBoxParol
            // 
            this.textBoxParol.Location = new System.Drawing.Point(5, 42);
            this.textBoxParol.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.Size = new System.Drawing.Size(128, 27);
            this.textBoxParol.TabIndex = 2;
            this.textBoxParol.Text = "Password";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(283, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(71, 64);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // panelConnect
            // 
            this.panelConnect.BackColor = System.Drawing.SystemColors.Control;
            this.panelConnect.Controls.Add(this.textBoxLogin);
            this.panelConnect.Controls.Add(this.buttonConnect);
            this.panelConnect.Controls.Add(this.textBoxParol);
            this.panelConnect.Location = new System.Drawing.Point(1, 1);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(366, 76);
            this.panelConnect.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSaveData);
            this.panel1.Controls.Add(this.checkedListBoxStudentInfo);
            this.panel1.Controls.Add(this.checkedListBoxStudentType);
            this.panel1.Location = new System.Drawing.Point(1, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 205);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student\'s information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student\'s type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(5, 174);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(358, 28);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "save to csv";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxStudentInfo
            // 
            this.checkedListBoxStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxStudentInfo.FormattingEnabled = true;
            this.checkedListBoxStudentInfo.Location = new System.Drawing.Point(131, 32);
            this.checkedListBoxStudentInfo.Name = "checkedListBoxStudentInfo";
            this.checkedListBoxStudentInfo.Size = new System.Drawing.Size(232, 136);
            this.checkedListBoxStudentInfo.TabIndex = 1;
            // 
            // checkedListBoxStudentType
            // 
            this.checkedListBoxStudentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxStudentType.FormattingEnabled = true;
            this.checkedListBoxStudentType.Location = new System.Drawing.Point(5, 32);
            this.checkedListBoxStudentType.Name = "checkedListBoxStudentType";
            this.checkedListBoxStudentType.Size = new System.Drawing.Size(120, 136);
            this.checkedListBoxStudentType.TabIndex = 0;
            this.checkedListBoxStudentType.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Calm Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxParol;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxStudentType;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.CheckedListBox checkedListBoxStudentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

