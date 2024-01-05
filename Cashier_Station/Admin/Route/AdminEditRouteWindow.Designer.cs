namespace Cashier_Station
{
    partial class AdminEditRouteWindow
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
            this.RouteGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.EndPoint = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartPoint = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DateArrival = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DateStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SeatsNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdRouteDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteGridView
            // 
            this.RouteGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RouteGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RouteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteGridView.Location = new System.Drawing.Point(56, 15);
            this.RouteGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RouteGridView.Name = "RouteGridView";
            this.RouteGridView.RowHeadersWidth = 51;
            this.RouteGridView.Size = new System.Drawing.Size(1212, 362);
            this.RouteGridView.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(399, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Point of arrival";
            // 
            // EndPoint
            // 
            this.EndPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EndPoint.BorderColorFocused = System.Drawing.Color.Gray;
            this.EndPoint.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EndPoint.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.EndPoint.BorderThickness = 3;
            this.EndPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndPoint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndPoint.ForeColor = System.Drawing.Color.White;
            this.EndPoint.isPassword = false;
            this.EndPoint.Location = new System.Drawing.Point(401, 433);
            this.EndPoint.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(340, 57);
            this.EndPoint.TabIndex = 10;
            this.EndPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Point of departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Route number";
            // 
            // StartPoint
            // 
            this.StartPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.StartPoint.BorderColorFocused = System.Drawing.Color.Gray;
            this.StartPoint.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartPoint.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.StartPoint.BorderThickness = 3;
            this.StartPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartPoint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPoint.ForeColor = System.Drawing.Color.White;
            this.StartPoint.isPassword = false;
            this.StartPoint.Location = new System.Drawing.Point(31, 544);
            this.StartPoint.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(340, 57);
            this.StartPoint.TabIndex = 8;
            this.StartPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DateArrival
            // 
            this.DateArrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DateArrival.BorderRadius = 0;
            this.DateArrival.ForeColor = System.Drawing.Color.White;
            this.DateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateArrival.FormatCustom = null;
            this.DateArrival.Location = new System.Drawing.Point(777, 433);
            this.DateArrival.Margin = new System.Windows.Forms.Padding(5);
            this.DateArrival.Name = "DateArrival";
            this.DateArrival.Size = new System.Drawing.Size(340, 57);
            this.DateArrival.TabIndex = 19;
            this.DateArrival.Value = new System.DateTime(2023, 11, 6, 18, 47, 4, 486);
            // 
            // DateStart
            // 
            this.DateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DateStart.BorderRadius = 0;
            this.DateStart.ForeColor = System.Drawing.Color.White;
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateStart.FormatCustom = null;
            this.DateStart.Location = new System.Drawing.Point(407, 544);
            this.DateStart.Margin = new System.Windows.Forms.Padding(5);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(340, 57);
            this.DateStart.TabIndex = 18;
            this.DateStart.Value = new System.DateTime(2023, 11, 6, 18, 47, 4, 486);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of seats";
            // 
            // SeatsNumber
            // 
            this.SeatsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SeatsNumber.BorderColorFocused = System.Drawing.Color.Gray;
            this.SeatsNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SeatsNumber.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.SeatsNumber.BorderThickness = 3;
            this.SeatsNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SeatsNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeatsNumber.ForeColor = System.Drawing.Color.White;
            this.SeatsNumber.isPassword = false;
            this.SeatsNumber.Location = new System.Drawing.Point(783, 544);
            this.SeatsNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SeatsNumber.Name = "SeatsNumber";
            this.SeatsNumber.Size = new System.Drawing.Size(340, 57);
            this.SeatsNumber.TabIndex = 16;
            this.SeatsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(769, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date of arrival";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 500);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of departure";
            // 
            // IdRouteDropDown
            // 
            this.IdRouteDropDown.BackColor = System.Drawing.Color.Transparent;
            this.IdRouteDropDown.BorderRadius = 3;
            this.IdRouteDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.IdRouteDropDown.ForeColor = System.Drawing.Color.White;
            this.IdRouteDropDown.Items = new string[0];
            this.IdRouteDropDown.Location = new System.Drawing.Point(31, 433);
            this.IdRouteDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.IdRouteDropDown.Name = "IdRouteDropDown";
            this.IdRouteDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.IdRouteDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.IdRouteDropDown.selectedIndex = -1;
            this.IdRouteDropDown.Size = new System.Drawing.Size(340, 57);
            this.IdRouteDropDown.TabIndex = 20;
            this.IdRouteDropDown.onItemSelected += new System.EventHandler(this.IdRouteDropDown_onItemSelected);
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(1133, 544);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(184, 57);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Edit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1293, 1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminEditRouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1333, 639);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IdRouteDropDown);
            this.Controls.Add(this.DateArrival);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeatsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.RouteGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminEditRouteWindow";
            this.Text = "AdminEditRouteWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RouteGridView;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox EndPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox StartPoint;
        private Bunifu.Framework.UI.BunifuDatepicker DateArrival;
        private Bunifu.Framework.UI.BunifuDatepicker DateStart;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox SeatsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown IdRouteDropDown;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ExitButton;
    }
}