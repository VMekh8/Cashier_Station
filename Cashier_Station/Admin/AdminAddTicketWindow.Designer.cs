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
            this.label4 = new System.Windows.Forms.Label();
            this.RouteNumberTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RouteNumberTextBox);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PriceTicketTextBox);
            this.panel1.Controls.Add(this.IdTicketTextBox);
            this.panel1.Location = new System.Drawing.Point(207, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 380);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Номер маршруту";
            // 
            // RouteNumberTextBox
            // 
            this.RouteNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RouteNumberTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.RouteNumberTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RouteNumberTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.RouteNumberTextBox.BorderThickness = 3;
            this.RouteNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RouteNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.RouteNumberTextBox.isPassword = false;
            this.RouteNumberTextBox.Location = new System.Drawing.Point(35, 241);
            this.RouteNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RouteNumberTextBox.Name = "RouteNumberTextBox";
            this.RouteNumberTextBox.Size = new System.Drawing.Size(500, 46);
            this.RouteNumberTextBox.TabIndex = 4;
            this.RouteNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ціна квитка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер квитка";
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
            this.PriceTicketTextBox.Location = new System.Drawing.Point(35, 152);
            this.PriceTicketTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PriceTicketTextBox.Name = "PriceTicketTextBox";
            this.PriceTicketTextBox.Size = new System.Drawing.Size(500, 46);
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
            this.IdTicketTextBox.Location = new System.Drawing.Point(35, 56);
            this.IdTicketTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.IdTicketTextBox.Name = "IdTicketTextBox";
            this.IdTicketTextBox.Size = new System.Drawing.Size(500, 46);
            this.IdTicketTextBox.TabIndex = 0;
            this.IdTicketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(955, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminAddTicketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddTicketWindow";
            this.Text = "AdminAddTicketWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox RouteNumberTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox PriceTicketTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox IdTicketTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}