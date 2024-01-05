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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.IdTicketDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketPriceTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IdRouteDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketGridView
            // 
            this.TicketGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Location = new System.Drawing.Point(59, 15);
            this.TicketGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TicketGridView.Size = new System.Drawing.Size(1212, 362);
            this.TicketGridView.TabIndex = 2;
            // 
            // IdTicketDropDown
            // 
            this.IdTicketDropDown.BackColor = System.Drawing.Color.Transparent;
            this.IdTicketDropDown.BorderRadius = 3;
            this.IdTicketDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.IdTicketDropDown.ForeColor = System.Drawing.Color.White;
            this.IdTicketDropDown.Items = new string[0];
            this.IdTicketDropDown.Location = new System.Drawing.Point(59, 441);
            this.IdTicketDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.IdTicketDropDown.Name = "IdTicketDropDown";
            this.IdTicketDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdTicketDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdTicketDropDown.selectedIndex = -1;
            this.IdTicketDropDown.Size = new System.Drawing.Size(400, 57);
            this.IdTicketDropDown.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select the ticket number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Route number";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(587, 545);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(299, 79);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Edit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ticket price";
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
            this.TicketPriceTextBox.Location = new System.Drawing.Point(587, 441);
            this.TicketPriceTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TicketPriceTextBox.Name = "TicketPriceTextBox";
            this.TicketPriceTextBox.Size = new System.Drawing.Size(400, 57);
            this.TicketPriceTextBox.TabIndex = 11;
            this.TicketPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1291, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IdRouteDropDown
            // 
            this.IdRouteDropDown.BackColor = System.Drawing.Color.Transparent;
            this.IdRouteDropDown.BorderRadius = 3;
            this.IdRouteDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.IdRouteDropDown.ForeColor = System.Drawing.Color.White;
            this.IdRouteDropDown.Items = new string[0];
            this.IdRouteDropDown.Location = new System.Drawing.Point(58, 571);
            this.IdRouteDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.IdRouteDropDown.Name = "IdRouteDropDown";
            this.IdRouteDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdRouteDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdRouteDropDown.selectedIndex = -1;
            this.IdRouteDropDown.Size = new System.Drawing.Size(405, 57);
            this.IdRouteDropDown.TabIndex = 22;
            // 
            // AdminTicketEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1333, 639);
            this.Controls.Add(this.IdRouteDropDown);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TicketPriceTextBox);
            this.Controls.Add(this.IdTicketDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminTicketEditWindow";
            this.Text = "AdminTicketEditWindow";
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketGridView;
        private Bunifu.Framework.UI.BunifuDropdown IdTicketDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TicketPriceTextBox;
        private System.Windows.Forms.Button ExitButton;
        private Bunifu.Framework.UI.BunifuDropdown IdRouteDropDown;
    }
}