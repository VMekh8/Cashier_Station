namespace Cashier_Station
{
    partial class AdminTicketEditWindow
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
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.IdTicletDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RouteNumberTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketPriceTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketGridView
            // 
            this.TicketGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Location = new System.Drawing.Point(44, 12);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.Size = new System.Drawing.Size(909, 294);
            this.TicketGridView.TabIndex = 2;
            // 
            // IdTicletDropDown
            // 
            this.IdTicletDropDown.BackColor = System.Drawing.Color.Transparent;
            this.IdTicletDropDown.BorderRadius = 3;
            this.IdTicletDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.IdTicletDropDown.ForeColor = System.Drawing.Color.White;
            this.IdTicletDropDown.Items = new string[0];
            this.IdTicletDropDown.Location = new System.Drawing.Point(44, 358);
            this.IdTicletDropDown.Name = "IdTicletDropDown";
            this.IdTicletDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdTicletDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdTicletDropDown.selectedIndex = -1;
            this.IdTicletDropDown.Size = new System.Drawing.Size(300, 46);
            this.IdTicletDropDown.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Виберіть номер квитка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер маршруту";
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
            this.RouteNumberTextBox.Location = new System.Drawing.Point(44, 458);
            this.RouteNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RouteNumberTextBox.Name = "RouteNumberTextBox";
            this.RouteNumberTextBox.Size = new System.Drawing.Size(300, 46);
            this.RouteNumberTextBox.TabIndex = 14;
            this.RouteNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(440, 443);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(224, 64);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Редагувати";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(434, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ціна квитка";
            // 
            // TicketPriceTextBox
            // 
            this.TicketPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TicketPriceTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.TicketPriceTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TicketPriceTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.TicketPriceTextBox.BorderThickness = 3;
            this.TicketPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TicketPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.TicketPriceTextBox.isPassword = false;
            this.TicketPriceTextBox.Location = new System.Drawing.Point(440, 358);
            this.TicketPriceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TicketPriceTextBox.Name = "TicketPriceTextBox";
            this.TicketPriceTextBox.Size = new System.Drawing.Size(300, 46);
            this.TicketPriceTextBox.TabIndex = 11;
            this.TicketPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(968, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminTicketEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteNumberTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TicketPriceTextBox);
            this.Controls.Add(this.IdTicletDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminTicketEditWindow";
            this.Text = "AdminTicketEditWindow";
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketGridView;
        private Bunifu.Framework.UI.BunifuDropdown IdTicletDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox RouteNumberTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TicketPriceTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}