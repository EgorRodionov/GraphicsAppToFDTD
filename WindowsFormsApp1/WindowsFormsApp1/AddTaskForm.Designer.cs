
namespace WindowsFormsApp1
{
    partial class AddTaskForm
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
            this.ForStudentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTaskTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.labelAddSotrudnik.Text = "Добавление новой задачи";
            this.labelAddSotrudnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForStudentComboBox
            // 
            this.ForStudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForStudentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForStudentComboBox.FormattingEnabled = true;
            this.ForStudentComboBox.Location = new System.Drawing.Point(300, 134);
            this.ForStudentComboBox.Name = "ForStudentComboBox";
            this.ForStudentComboBox.Size = new System.Drawing.Size(461, 39);
            this.ForStudentComboBox.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(94, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 96;
            this.label4.Text = "Для студента";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentTextBox.Location = new System.Drawing.Point(300, 224);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(461, 39);
            this.ContentTextBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 91;
            this.label1.Text = "Содержание";
            // 
            // TitleTaskTextBox
            // 
            this.TitleTaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTaskTextBox.Location = new System.Drawing.Point(300, 179);
            this.TitleTaskTextBox.Multiline = true;
            this.TitleTaskTextBox.Name = "TitleTaskTextBox";
            this.TitleTaskTextBox.Size = new System.Drawing.Size(461, 39);
            this.TitleTaskTextBox.TabIndex = 90;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(445, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 73);
            this.btnBack.TabIndex = 89;
            this.btnBack.Text = "Отмена";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionLabel.Location = new System.Drawing.Point(43, 182);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(244, 32);
            this.ConditionLabel.TabIndex = 88;
            this.ConditionLabel.Text = "Название задачи";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(226, 349);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(199, 73);
            this.btnCreate.TabIndex = 87;
            this.btnCreate.Text = "Добавить";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelAddSotrudnik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 86;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.ForStudentComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTaskTextBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTaskForm";
            this.Text = "Добавление задания";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddSotrudnik;
        private System.Windows.Forms.ComboBox ForStudentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTaskTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
    }
}