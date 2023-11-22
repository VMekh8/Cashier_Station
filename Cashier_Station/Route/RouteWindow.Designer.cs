namespace Cashier_Station
{
    partial class RouteWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LongestRouteName = new System.Windows.Forms.Label();
            this.LongestRouteRange = new System.Windows.Forms.Label();
            this.AnalyseRouteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.RouteGridView.Location = new System.Drawing.Point(43, 197);
            this.RouteGridView.Name = "RouteGridView";
            this.RouteGridView.Size = new System.Drawing.Size(909, 294);
            this.RouteGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Маршрути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Найдовший маршрут";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.flowLayoutPanel1.Controls.Add(this.LongestRouteName);
            this.flowLayoutPanel1.Controls.Add(this.LongestRouteRange);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 85);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LongestRouteName
            // 
            this.LongestRouteName.AutoSize = true;
            this.LongestRouteName.Font = new System.Drawing.Font("Microsoft YaHei", 16.75F, System.Drawing.FontStyle.Bold);
            this.LongestRouteName.ForeColor = System.Drawing.Color.White;
            this.LongestRouteName.Location = new System.Drawing.Point(3, 0);
            this.LongestRouteName.Name = "LongestRouteName";
            this.LongestRouteName.Size = new System.Drawing.Size(270, 31);
            this.LongestRouteName.TabIndex = 4;
            this.LongestRouteName.Text = "Найдовший маршрут";
            // 
            // LongestRouteRange
            // 
            this.LongestRouteRange.AutoSize = true;
            this.LongestRouteRange.Font = new System.Drawing.Font("Microsoft YaHei", 13.75F, System.Drawing.FontStyle.Bold);
            this.LongestRouteRange.ForeColor = System.Drawing.Color.White;
            this.LongestRouteRange.Location = new System.Drawing.Point(3, 31);
            this.LongestRouteRange.Name = "LongestRouteRange";
            this.LongestRouteRange.Size = new System.Drawing.Size(230, 26);
            this.LongestRouteRange.TabIndex = 5;
            this.LongestRouteRange.Text = "Найдовший маршрут";
            // 
            // AnalyseRouteButton
            // 
            this.AnalyseRouteButton.FlatAppearance.BorderSize = 3;
            this.AnalyseRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseRouteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyseRouteButton.ForeColor = System.Drawing.Color.White;
            this.AnalyseRouteButton.Location = new System.Drawing.Point(636, 128);
            this.AnalyseRouteButton.Name = "AnalyseRouteButton";
            this.AnalyseRouteButton.Size = new System.Drawing.Size(316, 54);
            this.AnalyseRouteButton.TabIndex = 4;
            this.AnalyseRouteButton.Text = "Аналіз частоти відправлень";
            this.AnalyseRouteButton.UseVisualStyleBackColor = true;
            this.AnalyseRouteButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.AnalyseRouteButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RouteWindow";
            this.Text = "RouteWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RouteGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LongestRouteName;
        private System.Windows.Forms.Label LongestRouteRange;
        private System.Windows.Forms.Button AnalyseRouteButton;
    }
}