﻿
namespace WindowsFormsApp1
{
    partial class DialogForm3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnchorPointTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeObjectTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveObjectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Характеристика для объекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.AnchorPointTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SizeObjectTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(165, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // AnchorPointTextBox
            // 
            this.AnchorPointTextBox.Location = new System.Drawing.Point(327, 127);
            this.AnchorPointTextBox.Name = "AnchorPointTextBox";
            this.AnchorPointTextBox.Size = new System.Drawing.Size(184, 34);
            this.AnchorPointTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Точка привязки:";
            // 
            // SizeObjectTextBox
            // 
            this.SizeObjectTextBox.Location = new System.Drawing.Point(327, 74);
            this.SizeObjectTextBox.Name = "SizeObjectTextBox";
            this.SizeObjectTextBox.Size = new System.Drawing.Size(184, 34);
            this.SizeObjectTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Размер объекта:";
            // 
            // SaveObjectBtn
            // 
            this.SaveObjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveObjectBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveObjectBtn.FlatAppearance.BorderSize = 0;
            this.SaveObjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveObjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveObjectBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveObjectBtn.Location = new System.Drawing.Point(272, 418);
            this.SaveObjectBtn.Name = "SaveObjectBtn";
            this.SaveObjectBtn.Size = new System.Drawing.Size(175, 53);
            this.SaveObjectBtn.TabIndex = 32;
            this.SaveObjectBtn.Text = "Сохранить";
            this.SaveObjectBtn.UseVisualStyleBackColor = false;
            this.SaveObjectBtn.Click += new System.EventHandler(this.SaveObjectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(453, 418);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(175, 53);
            this.CancelBtn.TabIndex = 33;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // DialogForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(919, 507);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveObjectBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DialogForm3";
            this.Text = "Характеристика для объетов";
            this.Load += new System.EventHandler(this.DialogForm3_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox SizeObjectTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox AnchorPointTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveObjectBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}