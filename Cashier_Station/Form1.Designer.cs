namespace Cashier_Station
{
    partial class MainWindow
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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.HorizontalLinePanel = new System.Windows.Forms.Panel();
            this.CashierLabel = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.Mainlabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PanelWindow = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NavPanel.Controls.Add(this.HorizontalLinePanel);
            this.NavPanel.Controls.Add(this.CashierLabel);
            this.NavPanel.Controls.Add(this.AdminLabel);
            this.NavPanel.Controls.Add(this.Mainlabel);
            this.NavPanel.Controls.Add(this.ExitButton);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(4);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(1333, 149);
            this.NavPanel.TabIndex = 0;
            // 
            // HorizontalLinePanel
            // 
            this.HorizontalLinePanel.BackColor = System.Drawing.Color.White;
            this.HorizontalLinePanel.Location = new System.Drawing.Point(204, 116);
            this.HorizontalLinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.HorizontalLinePanel.Name = "HorizontalLinePanel";
            this.HorizontalLinePanel.Size = new System.Drawing.Size(1000, 4);
            this.HorizontalLinePanel.TabIndex = 5;
            // 
            // CashierLabel
            // 
            this.CashierLabel.AutoSize = true;
            this.CashierLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierLabel.ForeColor = System.Drawing.Color.White;
            this.CashierLabel.Location = new System.Drawing.Point(604, 60);
            this.CashierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CashierLabel.Name = "CashierLabel";
            this.CashierLabel.Size = new System.Drawing.Size(118, 41);
            this.CashierLabel.TabIndex = 4;
            this.CashierLabel.Text = "Cashier";
            this.CashierLabel.Click += new System.EventHandler(this.CashierLabel_Click);
            this.CashierLabel.MouseLeave += new System.EventHandler(this.CashierLabel_MouseLeave);
            this.CashierLabel.MouseHover += new System.EventHandler(this.CashierLabel_MouseHover);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.Color.White;
            this.AdminLabel.Location = new System.Drawing.Point(835, 60);
            this.AdminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(192, 41);
            this.AdminLabel.TabIndex = 3;
            this.AdminLabel.Text = "Admin Panel";
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            this.AdminLabel.MouseLeave += new System.EventHandler(this.AdminLabel_MouseLeave);
            this.AdminLabel.MouseHover += new System.EventHandler(this.AdminLabel_MouseHover);
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.Color.White;
            this.Mainlabel.Location = new System.Drawing.Point(347, 60);
            this.Mainlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(101, 41);
            this.Mainlabel.TabIndex = 2;
            this.Mainlabel.Text = "Home";
            this.Mainlabel.Click += new System.EventHandler(this.Mainlabel_Click);
            this.Mainlabel.MouseLeave += new System.EventHandler(this.Mainlabel_MouseLeave);
            this.Mainlabel.MouseHover += new System.EventHandler(this.Mainlabel_MouseHover);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1288, 4);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PanelWindow
            // 
            this.PanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWindow.Location = new System.Drawing.Point(0, 149);
            this.PanelWindow.Margin = new System.Windows.Forms.Padding(4);
            this.PanelWindow.Name = "PanelWindow";
            this.PanelWindow.Size = new System.Drawing.Size(1333, 639);
            this.PanelWindow.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.PanelWindow);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CashierLabel;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.Panel HorizontalLinePanel;
        public System.Windows.Forms.Panel PanelWindow;
    }
}

