
namespace WindowsFormsApp1
{
    partial class DialogForm2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.AddCharacteristicsBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearObjectBtn = new System.Windows.Forms.Button();
            this.ObjectComboBox = new System.Windows.Forms.ComboBox();
            this.AddObjectBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartExperimentBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.AddCharacteristicsBtn);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ClearObjectBtn);
            this.groupBox3.Controls.Add(this.ObjectComboBox);
            this.groupBox3.Controls.Add(this.AddObjectBtn);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(274, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1287, 445);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(1003, 287);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 91);
            this.listBox2.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(921, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AddCharacteristicsBtn
            // 
            this.AddCharacteristicsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCharacteristicsBtn.BackColor = System.Drawing.Color.Lime;
            this.AddCharacteristicsBtn.FlatAppearance.BorderSize = 0;
            this.AddCharacteristicsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCharacteristicsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCharacteristicsBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCharacteristicsBtn.Location = new System.Drawing.Point(921, 298);
            this.AddCharacteristicsBtn.Name = "AddCharacteristicsBtn";
            this.AddCharacteristicsBtn.Size = new System.Drawing.Size(51, 37);
            this.AddCharacteristicsBtn.TabIndex = 36;
            this.AddCharacteristicsBtn.Text = ">";
            this.AddCharacteristicsBtn.UseVisualStyleBackColor = false;
            this.AddCharacteristicsBtn.Click += new System.EventHandler(this.AddCharacteristicsBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Точечные",
            "Плоская волна"});
            this.comboBox2.Location = new System.Drawing.Point(649, 316);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 37);
            this.comboBox2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(10, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 63);
            this.label4.TabIndex = 34;
            this.label4.Text = "Добавьте источники плоской волны с разных сторон расчётной области (до 4-х):";
            // 
            // ClearObjectBtn
            // 
            this.ClearObjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearObjectBtn.BackColor = System.Drawing.Color.Gray;
            this.ClearObjectBtn.FlatAppearance.BorderSize = 0;
            this.ClearObjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearObjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearObjectBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearObjectBtn.Location = new System.Drawing.Point(921, 230);
            this.ClearObjectBtn.Name = "ClearObjectBtn";
            this.ClearObjectBtn.Size = new System.Drawing.Size(51, 37);
            this.ClearObjectBtn.TabIndex = 33;
            this.ClearObjectBtn.Text = "<";
            this.ClearObjectBtn.UseVisualStyleBackColor = false;
            // 
            // ObjectComboBox
            // 
            this.ObjectComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectComboBox.FormattingEnabled = true;
            this.ObjectComboBox.Items.AddRange(new object[] {
            "Прямоугольник",
            "Эллипс"});
            this.ObjectComboBox.Location = new System.Drawing.Point(649, 214);
            this.ObjectComboBox.Name = "ObjectComboBox";
            this.ObjectComboBox.Size = new System.Drawing.Size(249, 37);
            this.ObjectComboBox.TabIndex = 32;
            // 
            // AddObjectBtn
            // 
            this.AddObjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddObjectBtn.BackColor = System.Drawing.Color.Lime;
            this.AddObjectBtn.FlatAppearance.BorderSize = 0;
            this.AddObjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddObjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddObjectBtn.ForeColor = System.Drawing.Color.Black;
            this.AddObjectBtn.Location = new System.Drawing.Point(921, 187);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(51, 37);
            this.AddObjectBtn.TabIndex = 31;
            this.AddObjectBtn.Text = ">";
            this.AddObjectBtn.UseVisualStyleBackColor = false;
            this.AddObjectBtn.Click += new System.EventHandler(this.AddObjectBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(1003, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 91);
            this.listBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добавьте объекты в расчетную область:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Размеры расчётной области в микрометрах:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(649, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 34);
            this.textBox1.TabIndex = 12;
            // 
            // StartExperimentBtn
            // 
            this.StartExperimentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartExperimentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartExperimentBtn.Location = new System.Drawing.Point(558, 563);
            this.StartExperimentBtn.Name = "StartExperimentBtn";
            this.StartExperimentBtn.Size = new System.Drawing.Size(354, 50);
            this.StartExperimentBtn.TabIndex = 30;
            this.StartExperimentBtn.Text = "Запустить эксперимент";
            this.StartExperimentBtn.UseVisualStyleBackColor = true;
            this.StartExperimentBtn.Click += new System.EventHandler(this.OpenForm3Btn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(918, 563);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(200, 50);
            this.BackBtn.TabIndex = 31;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DialogForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1784, 709);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StartExperimentBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "DialogForm2";
            this.Text = "Параметры для эксперимента";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartExperimentBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddObjectBtn;
        private System.Windows.Forms.ComboBox ObjectComboBox;
        private System.Windows.Forms.Button ClearObjectBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddCharacteristicsBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
    }
}