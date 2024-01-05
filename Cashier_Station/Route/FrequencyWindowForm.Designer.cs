namespace Cashier_Station
{
    partial class FrequencyWindowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartPointTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndPointTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.AnalyseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RouteGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Analysis of the frequency of route occupancy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(437, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the starting point";
            // 
            // StartPointTextBox
            // 
            this.StartPointTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.StartPointTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.StartPointTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartPointTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.StartPointTextBox.BorderThickness = 3;
            this.StartPointTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartPointTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPointTextBox.ForeColor = System.Drawing.Color.White;
            this.StartPointTextBox.isPassword = false;
            this.StartPointTextBox.Location = new System.Drawing.Point(445, 484);
            this.StartPointTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartPointTextBox.Name = "StartPointTextBox";
            this.StartPointTextBox.Size = new System.Drawing.Size(428, 43);
            this.StartPointTextBox.TabIndex = 6;
            this.StartPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 542);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter the point of arrival";
            // 
            // EndPointTextBox
            // 
            this.EndPointTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EndPointTextBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.EndPointTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EndPointTextBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.EndPointTextBox.BorderThickness = 3;
            this.EndPointTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndPointTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndPointTextBox.ForeColor = System.Drawing.Color.White;
            this.EndPointTextBox.isPassword = false;
            this.EndPointTextBox.Location = new System.Drawing.Point(444, 581);
            this.EndPointTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EndPointTextBox.Name = "EndPointTextBox";
            this.EndPointTextBox.Size = new System.Drawing.Size(428, 43);
            this.EndPointTextBox.TabIndex = 8;
            this.EndPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AnalyseButton
            // 
            this.AnalyseButton.FlatAppearance.BorderSize = 3;
            this.AnalyseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyseButton.ForeColor = System.Drawing.Color.White;
            this.AnalyseButton.Location = new System.Drawing.Point(959, 542);
            this.AnalyseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnalyseButton.Name = "AnalyseButton";
            this.AnalyseButton.Size = new System.Drawing.Size(308, 82);
            this.AnalyseButton.TabIndex = 10;
            this.AnalyseButton.Text = "Analysis";
            this.AnalyseButton.UseVisualStyleBackColor = true;
            this.AnalyseButton.Click += new System.EventHandler(this.AnalyseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1292, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.RouteGridView.Location = new System.Drawing.Point(55, 63);
            this.RouteGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RouteGridView.Name = "RouteGridView";
            this.RouteGridView.RowHeadersWidth = 51;
            this.RouteGridView.Size = new System.Drawing.Size(1212, 362);
            this.RouteGridView.TabIndex = 12;
            // 
            // FrequencyWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1333, 639);
            this.Controls.Add(this.RouteGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AnalyseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndPointTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartPointTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrequencyWindowForm";
            this.Text = "FrequencyWindowForm";
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox StartPointTextBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox EndPointTextBox;
        private System.Windows.Forms.Button AnalyseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView RouteGridView;
    }
}