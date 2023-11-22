﻿namespace Cashier_Station
{
    partial class TicketWindowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.RouteIdForTicket = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FindSeatButton = new System.Windows.Forms.Button();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.ReturnTicketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Квитки";
            // 
            // TicketGridView
            // 
            this.TicketGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Location = new System.Drawing.Point(41, 51);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.Size = new System.Drawing.Size(909, 294);
            this.TicketGridView.TabIndex = 3;
            // 
            // RouteIdForTicket
            // 
            this.RouteIdForTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RouteIdForTicket.BorderColorFocused = System.Drawing.Color.Gray;
            this.RouteIdForTicket.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RouteIdForTicket.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.RouteIdForTicket.BorderThickness = 3;
            this.RouteIdForTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RouteIdForTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteIdForTicket.ForeColor = System.Drawing.Color.White;
            this.RouteIdForTicket.isPassword = false;
            this.RouteIdForTicket.Location = new System.Drawing.Point(413, 361);
            this.RouteIdForTicket.Margin = new System.Windows.Forms.Padding(5);
            this.RouteIdForTicket.Name = "RouteIdForTicket";
            this.RouteIdForTicket.Size = new System.Drawing.Size(314, 46);
            this.RouteIdForTicket.TabIndex = 4;
            this.RouteIdForTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FindSeatButton
            // 
            this.FindSeatButton.FlatAppearance.BorderSize = 3;
            this.FindSeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindSeatButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSeatButton.ForeColor = System.Drawing.Color.White;
            this.FindSeatButton.Location = new System.Drawing.Point(735, 361);
            this.FindSeatButton.Name = "FindSeatButton";
            this.FindSeatButton.Size = new System.Drawing.Size(215, 46);
            this.FindSeatButton.TabIndex = 7;
            this.FindSeatButton.Text = "Знайти місця";
            this.FindSeatButton.UseVisualStyleBackColor = true;
            this.FindSeatButton.Click += new System.EventHandler(this.FindSeatButton_Click);
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.FlatAppearance.BorderSize = 3;
            this.BuyTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyTicketButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyTicketButton.ForeColor = System.Drawing.Color.White;
            this.BuyTicketButton.Location = new System.Drawing.Point(41, 361);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(215, 46);
            this.BuyTicketButton.TabIndex = 8;
            this.BuyTicketButton.Text = "Купити квиток";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // ReturnTicketButton
            // 
            this.ReturnTicketButton.FlatAppearance.BorderSize = 3;
            this.ReturnTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnTicketButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnTicketButton.ForeColor = System.Drawing.Color.White;
            this.ReturnTicketButton.Location = new System.Drawing.Point(41, 415);
            this.ReturnTicketButton.Name = "ReturnTicketButton";
            this.ReturnTicketButton.Size = new System.Drawing.Size(215, 46);
            this.ReturnTicketButton.TabIndex = 9;
            this.ReturnTicketButton.Text = "Повернути квиток";
            this.ReturnTicketButton.UseVisualStyleBackColor = true;
            this.ReturnTicketButton.Click += new System.EventHandler(this.ReturnTicketButton_Click);
            // 
            // TicketWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.ReturnTicketButton);
            this.Controls.Add(this.BuyTicketButton);
            this.Controls.Add(this.FindSeatButton);
            this.Controls.Add(this.RouteIdForTicket);
            this.Controls.Add(this.TicketGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketWindowForm";
            this.Text = "TicketWindowForm";
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TicketGridView;
        private Bunifu.Framework.UI.BunifuMetroTextbox RouteIdForTicket;
        private System.Windows.Forms.Button FindSeatButton;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Button ReturnTicketButton;
    }
}