namespace Cashier_Station
{
    partial class ClientWindowForm
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
            this.GotoRouteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsrnameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GotoRouteButton
            // 
            this.GotoRouteButton.FlatAppearance.BorderSize = 3;
            this.GotoRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GotoRouteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GotoRouteButton.ForeColor = System.Drawing.Color.White;
            this.GotoRouteButton.Location = new System.Drawing.Point(44, 119);
            this.GotoRouteButton.Name = "GotoRouteButton";
            this.GotoRouteButton.Size = new System.Drawing.Size(244, 73);
            this.GotoRouteButton.TabIndex = 7;
            this.GotoRouteButton.Text = "Інформація про клієнтів";
            this.GotoRouteButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(691, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "Пошук квитків за прізвищем";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 294);
            this.dataGridView1.TabIndex = 9;
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
            this.UsrnameTextBox.Location = new System.Drawing.Point(410, 119);
            this.UsrnameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsrnameTextBox.Name = "UsrnameTextBox";
            this.UsrnameTextBox.Size = new System.Drawing.Size(273, 70);
            this.UsrnameTextBox.TabIndex = 10;
            this.UsrnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Клієнти";
            // 
            // ClientWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsrnameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GotoRouteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientWindowForm";
            this.Text = "ClientWindowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GotoRouteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox UsrnameTextBox;
        private System.Windows.Forms.Label label1;
    }
}