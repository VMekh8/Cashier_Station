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
            this.RouteGridView.Location = new System.Drawing.Point(57, 242);
            this.RouteGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RouteGridView.Name = "RouteGridView";
            this.RouteGridView.RowHeadersWidth = 51;
            this.RouteGridView.Size = new System.Drawing.Size(1212, 362);
            this.RouteGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Routes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "The longest route";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.flowLayoutPanel1.Controls.Add(this.LongestRouteName);
            this.flowLayoutPanel1.Controls.Add(this.LongestRouteRange);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 119);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 105);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LongestRouteName
            // 
            this.LongestRouteName.Font = new System.Drawing.Font("Microsoft YaHei", 16.75F, System.Drawing.FontStyle.Bold);
            this.LongestRouteName.ForeColor = System.Drawing.Color.White;
            this.LongestRouteName.Location = new System.Drawing.Point(4, 0);
            this.LongestRouteName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LongestRouteName.Name = "LongestRouteName";
            this.LongestRouteName.Size = new System.Drawing.Size(360, 50);
            this.LongestRouteName.TabIndex = 4;
            // 
            // LongestRouteRange
            // 
            this.LongestRouteRange.Font = new System.Drawing.Font("Microsoft YaHei", 13.75F, System.Drawing.FontStyle.Bold);
            this.LongestRouteRange.ForeColor = System.Drawing.Color.White;
            this.LongestRouteRange.Location = new System.Drawing.Point(4, 50);
            this.LongestRouteRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LongestRouteRange.Name = "LongestRouteRange";
            this.LongestRouteRange.Size = new System.Drawing.Size(307, 42);
            this.LongestRouteRange.TabIndex = 5;
            // 
            // AnalyseRouteButton
            // 
            this.AnalyseRouteButton.FlatAppearance.BorderSize = 3;
            this.AnalyseRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseRouteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyseRouteButton.ForeColor = System.Drawing.Color.White;
            this.AnalyseRouteButton.Location = new System.Drawing.Point(808, 138);
            this.AnalyseRouteButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnalyseRouteButton.Name = "AnalyseRouteButton";
            this.AnalyseRouteButton.Size = new System.Drawing.Size(461, 86);
            this.AnalyseRouteButton.TabIndex = 4;
            this.AnalyseRouteButton.Text = "Analyze the frequency of shipments";
            this.AnalyseRouteButton.UseVisualStyleBackColor = true;
            this.AnalyseRouteButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1333, 639);
            this.Controls.Add(this.AnalyseRouteButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RouteWindow";
            this.Text = "RouteWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RouteGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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