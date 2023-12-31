﻿namespace Cashier_Station.Admin
{
    partial class EditTransportWindow
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
            this.TransportGridView = new System.Windows.Forms.DataGridView();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTransportTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TransportIdDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportGridView
            // 
            this.TransportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransportGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransportGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TransportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportGridView.Location = new System.Drawing.Point(52, 43);
            this.TransportGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransportGridView.Name = "TransportGridView";
            this.TransportGridView.RowHeadersWidth = 51;
            this.TransportGridView.Size = new System.Drawing.Size(1212, 362);
            this.TransportGridView.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(983, 466);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(281, 55);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Send";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(461, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name of transport ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transport number";
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
            this.NameTransportTextBox.Location = new System.Drawing.Point(469, 468);
            this.NameTransportTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NameTransportTextBox.Name = "NameTransportTextBox";
            this.NameTransportTextBox.Size = new System.Drawing.Size(340, 57);
            this.NameTransportTextBox.TabIndex = 6;
            this.NameTransportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TransportIdDropDown
            // 
            this.TransportIdDropDown.BackColor = System.Drawing.Color.Transparent;
            this.TransportIdDropDown.BorderRadius = 3;
            this.TransportIdDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.TransportIdDropDown.ForeColor = System.Drawing.Color.White;
            this.TransportIdDropDown.Items = new string[0];
            this.TransportIdDropDown.Location = new System.Drawing.Point(53, 465);
            this.TransportIdDropDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TransportIdDropDown.Name = "TransportIdDropDown";
            this.TransportIdDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TransportIdDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TransportIdDropDown.selectedIndex = -1;
            this.TransportIdDropDown.Size = new System.Drawing.Size(340, 57);
            this.TransportIdDropDown.TabIndex = 21;
            this.TransportIdDropDown.onItemSelected += new System.EventHandler(this.TransportIdDropDown_onItemSelected);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1272, -2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 31);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditTransportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 591);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TransportIdDropDown);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTransportTextBox);
            this.Controls.Add(this.TransportGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTransportWindow";
            this.Text = "EditTransportWindow";
            ((System.ComponentModel.ISupportInitialize)(this.TransportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransportGridView;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameTransportTextBox;
        private Bunifu.Framework.UI.BunifuDropdown TransportIdDropDown;
        private System.Windows.Forms.Button ExitButton;
    }
}