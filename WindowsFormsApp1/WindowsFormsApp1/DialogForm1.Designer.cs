
namespace WindowsFormsApp1
{
    partial class DialogForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogForm1));
            this.StartExperimentBtn = new System.Windows.Forms.Button();
            this.DataBaseBtn = new System.Windows.Forms.Button();
            this.RegistrBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoleLabel2 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.Loginlabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartExperimentBtn
            // 
            this.StartExperimentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartExperimentBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.StartExperimentBtn.FlatAppearance.BorderSize = 0;
            this.StartExperimentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartExperimentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartExperimentBtn.Location = new System.Drawing.Point(270, 378);
            this.StartExperimentBtn.Name = "StartExperimentBtn";
            this.StartExperimentBtn.Size = new System.Drawing.Size(431, 84);
            this.StartExperimentBtn.TabIndex = 0;
            this.StartExperimentBtn.Text = "Начать эксперимент";
            this.StartExperimentBtn.UseVisualStyleBackColor = false;
            this.StartExperimentBtn.Click += new System.EventHandler(this.StartExperimentBtn_Click);
            // 
            // DataBaseBtn
            // 
            this.DataBaseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataBaseBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.DataBaseBtn.FlatAppearance.BorderSize = 0;
            this.DataBaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataBaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataBaseBtn.Location = new System.Drawing.Point(270, 503);
            this.DataBaseBtn.Name = "DataBaseBtn";
            this.DataBaseBtn.Size = new System.Drawing.Size(431, 84);
            this.DataBaseBtn.TabIndex = 1;
            this.DataBaseBtn.Text = "База данных";
            this.DataBaseBtn.UseVisualStyleBackColor = false;
            this.DataBaseBtn.Click += new System.EventHandler(this.DataBaseBtn_Click);
            // 
            // RegistrBtn
            // 
            this.RegistrBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrBtn.BackColor = System.Drawing.Color.Yellow;
            this.RegistrBtn.FlatAppearance.BorderSize = 0;
            this.RegistrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrBtn.Location = new System.Drawing.Point(270, 628);
            this.RegistrBtn.Name = "RegistrBtn";
            this.RegistrBtn.Size = new System.Drawing.Size(431, 84);
            this.RegistrBtn.TabIndex = 2;
            this.RegistrBtn.Text = "Зарегистрировать";
            this.RegistrBtn.UseVisualStyleBackColor = false;
            this.RegistrBtn.Click += new System.EventHandler(this.RegistrBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(21, 33);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(99, 49);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 21;
            this.menuBtn.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.RoleLabel2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(669, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 38);
            this.panel2.TabIndex = 24;
            // 
            // RoleLabel2
            // 
            this.RoleLabel2.AutoSize = true;
            this.RoleLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.RoleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel2.ForeColor = System.Drawing.Color.White;
            this.RoleLabel2.Location = new System.Drawing.Point(193, 0);
            this.RoleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel2.Name = "RoleLabel2";
            this.RoleLabel2.Size = new System.Drawing.Size(85, 32);
            this.RoleLabel2.TabIndex = 0;
            this.RoleLabel2.Text = "Роль";
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.Loginlabel2);
            this.loginPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPanel.Location = new System.Drawing.Point(669, 69);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(278, 38);
            this.loginPanel.TabIndex = 25;
            // 
            // Loginlabel2
            // 
            this.Loginlabel2.AutoSize = true;
            this.Loginlabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Loginlabel2.ForeColor = System.Drawing.Color.White;
            this.Loginlabel2.Location = new System.Drawing.Point(184, 0);
            this.Loginlabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loginlabel2.Name = "Loginlabel2";
            this.Loginlabel2.Size = new System.Drawing.Size(94, 32);
            this.Loginlabel2.TabIndex = 0;
            this.Loginlabel2.Text = "Логин";
            // 
            // DialogForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(982, 1017);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.RegistrBtn);
            this.Controls.Add(this.DataBaseBtn);
            this.Controls.Add(this.StartExperimentBtn);
            this.Name = "DialogForm1";
            this.Text = "ВЛП";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogForm1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartExperimentBtn;
        private System.Windows.Forms.Button DataBaseBtn;
        private System.Windows.Forms.Button RegistrBtn;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RoleLabel2;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label Loginlabel2;
    }
}