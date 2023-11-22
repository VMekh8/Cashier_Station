namespace Cashier_Station.Models
{
    partial class BuyTicketAuthorization
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
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UsrnameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IdTicket = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.IdTicket);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.UsrnameTextBox);
            this.panel1.Location = new System.Drawing.Point(226, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 380);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Виберіть квиток";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(188, 315);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(211, 45);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Відправити";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть ім\'я";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SurnameTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.SurnameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SurnameTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.SurnameTextBox.BorderThickness = 3;
            this.SurnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.ForeColor = System.Drawing.Color.White;
            this.SurnameTextBox.isPassword = false;
            this.SurnameTextBox.Location = new System.Drawing.Point(35, 152);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(500, 46);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UsrnameTextBox
            // 
            this.UsrnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UsrnameTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.UsrnameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsrnameTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.UsrnameTextBox.BorderThickness = 3;
            this.UsrnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsrnameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsrnameTextBox.ForeColor = System.Drawing.Color.White;
            this.UsrnameTextBox.isPassword = false;
            this.UsrnameTextBox.Location = new System.Drawing.Point(35, 56);
            this.UsrnameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsrnameTextBox.Name = "UsrnameTextBox";
            this.UsrnameTextBox.Size = new System.Drawing.Size(500, 46);
            this.UsrnameTextBox.TabIndex = 0;
            this.UsrnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заповнення інформації для покупки квитка";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(969, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IdTicket
            // 
            this.IdTicket.BackColor = System.Drawing.Color.Transparent;
            this.IdTicket.BorderRadius = 3;
            this.IdTicket.DisabledColor = System.Drawing.Color.Gray;
            this.IdTicket.ForeColor = System.Drawing.Color.White;
            this.IdTicket.Items = new string[0];
            this.IdTicket.Location = new System.Drawing.Point(35, 244);
            this.IdTicket.Name = "IdTicket";
            this.IdTicket.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdTicket.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdTicket.selectedIndex = -1;
            this.IdTicket.Size = new System.Drawing.Size(500, 46);
            this.IdTicket.TabIndex = 7;
            // 
            // BuyTicketAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyTicketAuthorization";
            this.Text = "BuyTicketAuthorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox UsrnameTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox SurnameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private Bunifu.Framework.UI.BunifuDropdown IdTicket;
    }
}