namespace Cashier_Station.Admin
{
    partial class InterMediateRouteWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ArrivalTime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DistanceToEnd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DistanceFromStart = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Routeid = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTransportTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RouteIdDelete = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NameStationDelete = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.ArrivalTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DistanceToEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DistanceFromStart);
            this.panel1.Controls.Add(this.Routeid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameTransportTextBox);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 495);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Дата прибуття";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(171, 450);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(211, 45);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Додати";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ArrivalTime.BorderRadius = 0;
            this.ArrivalTime.ForeColor = System.Drawing.Color.White;
            this.ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTime.FormatCustom = "MM/dd/yyyy hh:mm:ss";
            this.ArrivalTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArrivalTime.Location = new System.Drawing.Point(37, 396);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(444, 46);
            this.ArrivalTime.TabIndex = 27;
            this.ArrivalTime.Value = new System.DateTime(2023, 11, 6, 18, 47, 4, 486);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Відстань до кінцевої станції";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DistanceToEnd
            // 
            this.DistanceToEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DistanceToEnd.BorderColorFocused = System.Drawing.Color.Gray;
            this.DistanceToEnd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DistanceToEnd.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.DistanceToEnd.BorderThickness = 3;
            this.DistanceToEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DistanceToEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceToEnd.ForeColor = System.Drawing.Color.White;
            this.DistanceToEnd.isPassword = false;
            this.DistanceToEnd.Location = new System.Drawing.Point(37, 310);
            this.DistanceToEnd.Margin = new System.Windows.Forms.Padding(5);
            this.DistanceToEnd.Name = "DistanceToEnd";
            this.DistanceToEnd.Size = new System.Drawing.Size(444, 46);
            this.DistanceToEnd.TabIndex = 25;
            this.DistanceToEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Відстань від початкової станції";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DistanceFromStart
            // 
            this.DistanceFromStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DistanceFromStart.BorderColorFocused = System.Drawing.Color.Gray;
            this.DistanceFromStart.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DistanceFromStart.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.DistanceFromStart.BorderThickness = 3;
            this.DistanceFromStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DistanceFromStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceFromStart.ForeColor = System.Drawing.Color.White;
            this.DistanceFromStart.isPassword = false;
            this.DistanceFromStart.Location = new System.Drawing.Point(37, 213);
            this.DistanceFromStart.Margin = new System.Windows.Forms.Padding(5);
            this.DistanceFromStart.Name = "DistanceFromStart";
            this.DistanceFromStart.Size = new System.Drawing.Size(444, 46);
            this.DistanceFromStart.TabIndex = 23;
            this.DistanceFromStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Routeid
            // 
            this.Routeid.BackColor = System.Drawing.Color.Transparent;
            this.Routeid.BorderRadius = 3;
            this.Routeid.DisabledColor = System.Drawing.Color.Gray;
            this.Routeid.ForeColor = System.Drawing.Color.White;
            this.Routeid.Items = new string[0];
            this.Routeid.Location = new System.Drawing.Point(37, 36);
            this.Routeid.Name = "Routeid";
            this.Routeid.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Routeid.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Routeid.selectedIndex = -1;
            this.Routeid.Size = new System.Drawing.Size(444, 46);
            this.Routeid.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва станції";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер маршруту";
            // 
            // NameTransportTextBox
            // 
            this.NameTransportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameTransportTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.NameTransportTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTransportTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.NameTransportTextBox.BorderThickness = 3;
            this.NameTransportTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTransportTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTransportTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTransportTextBox.isPassword = false;
            this.NameTransportTextBox.Location = new System.Drawing.Point(37, 121);
            this.NameTransportTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameTransportTextBox.Name = "NameTransportTextBox";
            this.NameTransportTextBox.Size = new System.Drawing.Size(444, 46);
            this.NameTransportTextBox.TabIndex = 1;
            this.NameTransportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.RouteIdDelete);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.NameStationDelete);
            this.panel2.Location = new System.Drawing.Point(565, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 459);
            this.panel2.TabIndex = 29;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 3;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(87, 339);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(211, 45);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RouteIdDelete
            // 
            this.RouteIdDelete.BackColor = System.Drawing.Color.Transparent;
            this.RouteIdDelete.BorderRadius = 3;
            this.RouteIdDelete.DisabledColor = System.Drawing.Color.Gray;
            this.RouteIdDelete.ForeColor = System.Drawing.Color.White;
            this.RouteIdDelete.Items = new string[0];
            this.RouteIdDelete.Location = new System.Drawing.Point(33, 146);
            this.RouteIdDelete.Name = "RouteIdDelete";
            this.RouteIdDelete.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RouteIdDelete.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.RouteIdDelete.selectedIndex = -1;
            this.RouteIdDelete.Size = new System.Drawing.Size(329, 46);
            this.RouteIdDelete.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Назва станції";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Номер маршруту";
            // 
            // NameStationDelete
            // 
            this.NameStationDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameStationDelete.BorderColorFocused = System.Drawing.Color.Gray;
            this.NameStationDelete.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameStationDelete.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.NameStationDelete.BorderThickness = 3;
            this.NameStationDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameStationDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStationDelete.ForeColor = System.Drawing.Color.White;
            this.NameStationDelete.isPassword = false;
            this.NameStationDelete.Location = new System.Drawing.Point(33, 249);
            this.NameStationDelete.Margin = new System.Windows.Forms.Padding(5);
            this.NameStationDelete.Name = "NameStationDelete";
            this.NameStationDelete.Size = new System.Drawing.Size(329, 46);
            this.NameStationDelete.TabIndex = 1;
            this.NameStationDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(966, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 30;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InterMediateRouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterMediateRouteWindow";
            this.Text = "InterMediateRoute";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameTransportTextBox;
        private Bunifu.Framework.UI.BunifuDropdown Routeid;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox DistanceToEnd;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox DistanceFromStart;
        private Bunifu.Framework.UI.BunifuDatepicker ArrivalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteButton;
        private Bunifu.Framework.UI.BunifuDropdown RouteIdDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameStationDelete;
        private System.Windows.Forms.Button ExitButton;
    }
}