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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Аналіз частоти зайнятості маршрутів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(328, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть точку відправлення";
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
            this.StartPointTextBox.Location = new System.Drawing.Point(334, 393);
            this.StartPointTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartPointTextBox.Name = "StartPointTextBox";
            this.StartPointTextBox.Size = new System.Drawing.Size(321, 35);
            this.StartPointTextBox.TabIndex = 6;
            this.StartPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введіть точку прибуття";
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
            this.EndPointTextBox.Location = new System.Drawing.Point(333, 472);
            this.EndPointTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EndPointTextBox.Name = "EndPointTextBox";
            this.EndPointTextBox.Size = new System.Drawing.Size(321, 35);
            this.EndPointTextBox.TabIndex = 8;
            this.EndPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AnalyseButton
            // 
            this.AnalyseButton.FlatAppearance.BorderSize = 3;
            this.AnalyseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyseButton.ForeColor = System.Drawing.Color.White;
            this.AnalyseButton.Location = new System.Drawing.Point(719, 440);
            this.AnalyseButton.Name = "AnalyseButton";
            this.AnalyseButton.Size = new System.Drawing.Size(231, 67);
            this.AnalyseButton.TabIndex = 10;
            this.AnalyseButton.Text = "Аналіз";
            this.AnalyseButton.UseVisualStyleBackColor = true;
            this.AnalyseButton.Click += new System.EventHandler(this.AnalyseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(969, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 25);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RouteGridView
            // 
            this.RouteGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RouteGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RouteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteGridView.Location = new System.Drawing.Point(41, 51);
            this.RouteGridView.Name = "RouteGridView";
            this.RouteGridView.Size = new System.Drawing.Size(909, 294);
            this.RouteGridView.TabIndex = 12;
            // 
            // FrequencyWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.RouteGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AnalyseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndPointTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartPointTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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