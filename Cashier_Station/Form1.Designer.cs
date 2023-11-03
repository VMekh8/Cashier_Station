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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PanelWindow = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Controls.Add(this.label3);
            this.NavPanel.Controls.Add(this.label2);
            this.NavPanel.Controls.Add(this.label1);
            this.NavPanel.Controls.Add(this.ExitButton);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(1000, 121);
            this.NavPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(153, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 3);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(475, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Каса";
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(626, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адмін Панель";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Головна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(966, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PanelWindow
            // 
            this.PanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWindow.Location = new System.Drawing.Point(0, 121);
            this.PanelWindow.Name = "PanelWindow";
            this.PanelWindow.Size = new System.Drawing.Size(1000, 519);
            this.PanelWindow.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.PanelWindow);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel PanelWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

