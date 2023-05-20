
namespace WindowsFormsApp1
{
    partial class AddStudentForm
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
            this.labelAddSotrudnik = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.GroupcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatronymictextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddSotrudnik
            // 
            this.labelAddSotrudnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddSotrudnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddSotrudnik.Location = new System.Drawing.Point(0, 0);
            this.labelAddSotrudnik.Name = "labelAddSotrudnik";
            this.labelAddSotrudnik.Size = new System.Drawing.Size(800, 75);
            this.labelAddSotrudnik.TabIndex = 2;
            this.labelAddSotrudnik.Text = "Добавление нового студента";
            this.labelAddSotrudnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailtextBox.Location = new System.Drawing.Point(327, 310);
            this.EmailtextBox.Multiline = true;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(317, 39);
            this.EmailtextBox.TabIndex = 85;
            // 
            // GroupcomboBox
            // 
            this.GroupcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupcomboBox.FormattingEnabled = true;
            this.GroupcomboBox.Location = new System.Drawing.Point(327, 130);
            this.GroupcomboBox.Name = "GroupcomboBox";
            this.GroupcomboBox.Size = new System.Drawing.Size(317, 39);
            this.GroupcomboBox.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 83;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(223, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 82;
            this.label3.Text = "Email";
            // 
            // PatronymictextBox3
            // 
            this.PatronymictextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymictextBox3.Location = new System.Drawing.Point(327, 265);
            this.PatronymictextBox3.Multiline = true;
            this.PatronymictextBox3.Name = "PatronymictextBox3";
            this.PatronymictextBox3.Size = new System.Drawing.Size(317, 39);
            this.PatronymictextBox3.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(182, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 80;
            this.label2.Text = "Отчество";
            // 
            // NametextBox2
            // 
            this.NametextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NametextBox2.Location = new System.Drawing.Point(327, 220);
            this.NametextBox2.Multiline = true;
            this.NametextBox2.Name = "NametextBox2";
            this.NametextBox2.Size = new System.Drawing.Size(317, 39);
            this.NametextBox2.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 78;
            this.label1.Text = "Имя";
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnametextBox.Location = new System.Drawing.Point(327, 175);
            this.SurnametextBox.Multiline = true;
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(317, 39);
            this.SurnametextBox.TabIndex = 77;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(445, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 73);
            this.btnBack.TabIndex = 76;
            this.btnBack.Text = "Отмена";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionLabel.Location = new System.Drawing.Point(183, 175);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(138, 32);
            this.ConditionLabel.TabIndex = 75;
            this.ConditionLabel.Text = "Фамилия";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(226, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 73);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelAddSotrudnik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 73;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.GroupcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatronymictextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddSotrudnik;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.ComboBox GroupcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatronymictextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NametextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnametextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}