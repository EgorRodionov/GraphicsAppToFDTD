
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxForSourceListBox = new System.Windows.Forms.ListBox();
            this.ClearSourceBtn = new System.Windows.Forms.Button();
            this.AddCharacteristicsBtn = new System.Windows.Forms.Button();
            this.SourceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearObjectBtn = new System.Windows.Forms.Button();
            this.ObjectComboBox = new System.Windows.Forms.ComboBox();
            this.AddObjectBtn = new System.Windows.Forms.Button();
            this.BoxForObjectListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WidthtextBox = new System.Windows.Forms.TextBox();
            this.StartExperimentBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BoxForSourceListBox);
            this.groupBox3.Controls.Add(this.ClearSourceBtn);
            this.groupBox3.Controls.Add(this.AddCharacteristicsBtn);
            this.groupBox3.Controls.Add(this.SourceComboBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ClearObjectBtn);
            this.groupBox3.Controls.Add(this.ObjectComboBox);
            this.groupBox3.Controls.Add(this.AddObjectBtn);
            this.groupBox3.Controls.Add(this.BoxForObjectListBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.WidthtextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(228, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1287, 349);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Добавленные объекты";
            // 
            // BoxForSourceListBox
            // 
            this.BoxForSourceListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxForSourceListBox.FormattingEnabled = true;
            this.BoxForSourceListBox.ItemHeight = 29;
            this.BoxForSourceListBox.Location = new System.Drawing.Point(945, 239);
            this.BoxForSourceListBox.Name = "BoxForSourceListBox";
            this.BoxForSourceListBox.Size = new System.Drawing.Size(316, 91);
            this.BoxForSourceListBox.TabIndex = 38;
            // 
            // ClearSourceBtn
            // 
            this.ClearSourceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearSourceBtn.BackColor = System.Drawing.Color.Gray;
            this.ClearSourceBtn.FlatAppearance.BorderSize = 0;
            this.ClearSourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSourceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSourceBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearSourceBtn.Location = new System.Drawing.Point(863, 293);
            this.ClearSourceBtn.Name = "ClearSourceBtn";
            this.ClearSourceBtn.Size = new System.Drawing.Size(51, 37);
            this.ClearSourceBtn.TabIndex = 37;
            this.ClearSourceBtn.Text = "<";
            this.ClearSourceBtn.UseVisualStyleBackColor = false;
            this.ClearSourceBtn.Click += new System.EventHandler(this.ClearSourceBtn_Click);
            // 
            // AddCharacteristicsBtn
            // 
            this.AddCharacteristicsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCharacteristicsBtn.BackColor = System.Drawing.Color.Lime;
            this.AddCharacteristicsBtn.FlatAppearance.BorderSize = 0;
            this.AddCharacteristicsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCharacteristicsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCharacteristicsBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCharacteristicsBtn.Location = new System.Drawing.Point(863, 250);
            this.AddCharacteristicsBtn.Name = "AddCharacteristicsBtn";
            this.AddCharacteristicsBtn.Size = new System.Drawing.Size(51, 37);
            this.AddCharacteristicsBtn.TabIndex = 36;
            this.AddCharacteristicsBtn.Text = ">";
            this.AddCharacteristicsBtn.UseVisualStyleBackColor = false;
            this.AddCharacteristicsBtn.Click += new System.EventHandler(this.AddCharacteristicsBtn_Click);
            // 
            // SourceComboBox
            // 
            this.SourceComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceComboBox.FormattingEnabled = true;
            this.SourceComboBox.Items.AddRange(new object[] {
            "Точечные",
            "Плоская волна"});
            this.SourceComboBox.Location = new System.Drawing.Point(591, 268);
            this.SourceComboBox.Name = "SourceComboBox";
            this.SourceComboBox.Size = new System.Drawing.Size(249, 37);
            this.SourceComboBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(6, 251);
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
            this.ClearObjectBtn.Location = new System.Drawing.Point(863, 182);
            this.ClearObjectBtn.Name = "ClearObjectBtn";
            this.ClearObjectBtn.Size = new System.Drawing.Size(51, 37);
            this.ClearObjectBtn.TabIndex = 33;
            this.ClearObjectBtn.Text = "<";
            this.ClearObjectBtn.UseVisualStyleBackColor = false;
            this.ClearObjectBtn.Click += new System.EventHandler(this.ClearObjectBtn_Click);
            // 
            // ObjectComboBox
            // 
            this.ObjectComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectComboBox.FormattingEnabled = true;
            this.ObjectComboBox.Items.AddRange(new object[] {
            "Прямоугольник",
            "Эллипс"});
            this.ObjectComboBox.Location = new System.Drawing.Point(591, 166);
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
            this.AddObjectBtn.Location = new System.Drawing.Point(863, 139);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(51, 37);
            this.AddObjectBtn.TabIndex = 31;
            this.AddObjectBtn.Text = ">";
            this.AddObjectBtn.UseVisualStyleBackColor = false;
            this.AddObjectBtn.Click += new System.EventHandler(this.AddObjectBtn_Click);
            // 
            // BoxForObjectListBox
            // 
            this.BoxForObjectListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxForObjectListBox.FormattingEnabled = true;
            this.BoxForObjectListBox.ItemHeight = 29;
            this.BoxForObjectListBox.Location = new System.Drawing.Point(945, 139);
            this.BoxForObjectListBox.Name = "BoxForObjectListBox";
            this.BoxForObjectListBox.Size = new System.Drawing.Size(316, 91);
            this.BoxForObjectListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добавьте объекты в расчетную область:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Размеры расчётной области в микрометрах:";
            // 
            // WidthtextBox
            // 
            this.WidthtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WidthtextBox.Location = new System.Drawing.Point(696, 42);
            this.WidthtextBox.Name = "WidthtextBox";
            this.WidthtextBox.Size = new System.Drawing.Size(110, 34);
            this.WidthtextBox.TabIndex = 12;
            // 
            // StartExperimentBtn
            // 
            this.StartExperimentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartExperimentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartExperimentBtn.Location = new System.Drawing.Point(1521, 910);
            this.StartExperimentBtn.Name = "StartExperimentBtn";
            this.StartExperimentBtn.Size = new System.Drawing.Size(261, 85);
            this.StartExperimentBtn.TabIndex = 30;
            this.StartExperimentBtn.Text = "Запустить эксперимент";
            this.StartExperimentBtn.UseVisualStyleBackColor = true;
            this.StartExperimentBtn.Click += new System.EventHandler(this.OpenForm3Btn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(934, 445);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(200, 50);
            this.BackBtn.TabIndex = 31;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Высота";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(945, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 34);
            this.textBox1.TabIndex = 41;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(228, 522);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1287, 473);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(574, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "Запустить эксперимент";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DialogForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1784, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StartExperimentBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "DialogForm2";
            this.Text = "Параметры для эксперимента";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox WidthtextBox;
        private System.Windows.Forms.Button StartExperimentBtn;
        private System.Windows.Forms.Button AddObjectBtn;
        private System.Windows.Forms.ComboBox ObjectComboBox;
        private System.Windows.Forms.Button ClearObjectBtn;
        private System.Windows.Forms.Button ClearSourceBtn;
        private System.Windows.Forms.Button AddCharacteristicsBtn;
        private System.Windows.Forms.ComboBox SourceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
        public System.Windows.Forms.ListBox BoxForObjectListBox;
        public System.Windows.Forms.ListBox BoxForSourceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}