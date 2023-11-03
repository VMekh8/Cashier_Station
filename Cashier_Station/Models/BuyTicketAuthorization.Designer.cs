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
            this.label1 = new System.Windows.Forms.Label();
            this.UsrnameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SurnameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заповнення інформації про клієнта";
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
            this.UsrnameTextBox.Location = new System.Drawing.Point(35, 71);
            this.UsrnameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsrnameTextBox.Name = "UsrnameTextBox";
            this.UsrnameTextBox.Size = new System.Drawing.Size(500, 46);
            this.UsrnameTextBox.TabIndex = 0;
            this.UsrnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.SurnameTextBox.Location = new System.Drawing.Point(35, 167);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(500, 46);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть прізвище";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(180, 268);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(209, 80);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Відправити";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // BuyTicketAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
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
    }
}