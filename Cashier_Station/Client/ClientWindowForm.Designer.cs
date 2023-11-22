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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientInfoButton = new System.Windows.Forms.Button();
            this.FindBySurButton = new System.Windows.Forms.Button();
            this.ClientDataGrid = new System.Windows.Forms.DataGridView();
            this.SurNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientInfoButton
            // 
            this.ClientInfoButton.FlatAppearance.BorderSize = 3;
            this.ClientInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientInfoButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientInfoButton.ForeColor = System.Drawing.Color.White;
            this.ClientInfoButton.Location = new System.Drawing.Point(44, 119);
            this.ClientInfoButton.Name = "ClientInfoButton";
            this.ClientInfoButton.Size = new System.Drawing.Size(244, 73);
            this.ClientInfoButton.TabIndex = 7;
            this.ClientInfoButton.Text = "Інформація про клієнтів";
            this.ClientInfoButton.UseVisualStyleBackColor = true;
            this.ClientInfoButton.Click += new System.EventHandler(this.ClientInfoButton_Click);
            // 
            // FindBySurButton
            // 
            this.FindBySurButton.FlatAppearance.BorderSize = 3;
            this.FindBySurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindBySurButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBySurButton.ForeColor = System.Drawing.Color.White;
            this.FindBySurButton.Location = new System.Drawing.Point(691, 119);
            this.FindBySurButton.Name = "FindBySurButton";
            this.FindBySurButton.Size = new System.Drawing.Size(262, 70);
            this.FindBySurButton.TabIndex = 8;
            this.FindBySurButton.Text = "Пошук квитків за прізвищем";
            this.FindBySurButton.UseVisualStyleBackColor = true;
            this.FindBySurButton.Click += new System.EventHandler(this.FindBySurButton_Click);
            // 
            // ClientDataGrid
            // 
            this.ClientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGrid.Location = new System.Drawing.Point(44, 213);
            this.ClientDataGrid.Name = "ClientDataGrid";
            this.ClientDataGrid.Size = new System.Drawing.Size(909, 294);
            this.ClientDataGrid.TabIndex = 9;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SurNameTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.SurNameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SurNameTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.SurNameTextBox.BorderThickness = 3;
            this.SurNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameTextBox.ForeColor = System.Drawing.Color.White;
            this.SurNameTextBox.isPassword = false;
            this.SurNameTextBox.Location = new System.Drawing.Point(410, 119);
            this.SurNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(273, 70);
            this.SurNameTextBox.TabIndex = 10;
            this.SurNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.ClientDataGrid);
            this.Controls.Add(this.FindBySurButton);
            this.Controls.Add(this.ClientInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientWindowForm";
            this.Text = "ClientWindowForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientInfoButton;
        private System.Windows.Forms.Button FindBySurButton;
        private System.Windows.Forms.DataGridView ClientDataGrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox SurNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}