namespace Cashier_Station
{
    partial class AdminAddTicketWindow
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
            this.IdRouteDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTicketTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IdTicketTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.IdRouteDropDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PriceTicketTextBox);
            this.panel1.Controls.Add(this.IdTicketTextBox);
            this.panel1.Location = new System.Drawing.Point(276, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 468);
            this.panel1.TabIndex = 1;
            // 
            // IdRouteDropDown
            // 
            this.IdRouteDropDown.BackColor = System.Drawing.Color.Transparent;
            this.IdRouteDropDown.BorderRadius = 3;
            this.IdRouteDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.IdRouteDropDown.ForeColor = System.Drawing.Color.White;
            this.IdRouteDropDown.Items = new string[0];
            this.IdRouteDropDown.Location = new System.Drawing.Point(47, 303);
            this.IdRouteDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.IdRouteDropDown.Name = "IdRouteDropDown";
            this.IdRouteDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdRouteDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdRouteDropDown.selectedIndex = -1;
            this.IdRouteDropDown.Size = new System.Drawing.Size(667, 57);
            this.IdRouteDropDown.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Route number";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(251, 388);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(281, 55);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Send";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ticket price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket number";
            // 
            // PriceTicketTextBox
            // 
            this.PriceTicketTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PriceTicketTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.PriceTicketTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTicketTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.PriceTicketTextBox.BorderThickness = 3;
            this.PriceTicketTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTicketTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTicketTextBox.ForeColor = System.Drawing.Color.White;
            this.PriceTicketTextBox.isPassword = false;
            this.PriceTicketTextBox.Location = new System.Drawing.Point(47, 187);
            this.PriceTicketTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PriceTicketTextBox.Name = "PriceTicketTextBox";
            this.PriceTicketTextBox.Size = new System.Drawing.Size(667, 57);
            this.PriceTicketTextBox.TabIndex = 1;
            this.PriceTicketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IdTicketTextBox
            // 
            this.IdTicketTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdTicketTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.IdTicketTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdTicketTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.IdTicketTextBox.BorderThickness = 3;
            this.IdTicketTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTicketTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTicketTextBox.ForeColor = System.Drawing.Color.White;
            this.IdTicketTextBox.isPassword = false;
            this.IdTicketTextBox.Location = new System.Drawing.Point(47, 69);
            this.IdTicketTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.IdTicketTextBox.Name = "IdTicketTextBox";
            this.IdTicketTextBox.Size = new System.Drawing.Size(667, 57);
            this.IdTicketTextBox.TabIndex = 0;
            this.IdTicketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1273, 1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminAddTicketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 591);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAddTicketWindow";
            this.Text = "AdminAddTicketWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox PriceTicketTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox IdTicketTextBox;
        private System.Windows.Forms.Button ExitButton;
        private Bunifu.Framework.UI.BunifuDropdown IdRouteDropDown;
    }
}