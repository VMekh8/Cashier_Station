namespace Cashier_Station
{
    partial class AdminDeleteRouteWindow
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
            this.RouteIdDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.RouteIdDropDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Location = new System.Drawing.Point(231, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 380);
            this.panel1.TabIndex = 6;
            // 
            // RouteIdDropDown
            // 
            this.RouteIdDropDown.BackColor = System.Drawing.Color.Transparent;
            this.RouteIdDropDown.BorderRadius = 3;
            this.RouteIdDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.RouteIdDropDown.ForeColor = System.Drawing.Color.White;
            this.RouteIdDropDown.Items = new string[0];
            this.RouteIdDropDown.Location = new System.Drawing.Point(37, 107);
            this.RouteIdDropDown.Name = "RouteIdDropDown";
            this.RouteIdDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RouteIdDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.RouteIdDropDown.selectedIndex = -1;
            this.RouteIdDropDown.Size = new System.Drawing.Size(500, 46);
            this.RouteIdDropDown.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Виберіть номер маршруту";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(164, 217);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(239, 74);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Видалити";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Видалення маршруту";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(969, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminDeleteRouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDeleteRouteWindow";
            this.Text = "AdminDeleteRouteWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown RouteIdDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}